using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallbackSharp
{
    public partial class Form1 : Form
    {

        // 1. 定义委托：签名必须与 C++ 的函数指针完全匹配。
        //    - C++ `void` -> C# `void`
        //    - C++ `const char*` -> C# `string` (with CharSet.Ansi)
        //    - C++ `__stdcall` -> C# `CallingConvention.StdCall`
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void ProgressCallbackDelegate(string message);

        // 2. 导入 C++ DLL 中的函数。
        //    确保 DLL 文件路径正确，或者将其放在可执行文件旁边。
        private const string DllPath = @"CppLibrary.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCallback(ProgressCallbackDelegate callback);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern void DoWorkAndNotify();

        // 3. (非常重要) 创建一个静态字段来持有委托实例。
        //    这可以防止它被垃圾回收器 (GC) 回收。如果委托被回收，
        //    C++ 将尝试调用一个无效的内存地址，导致程序崩溃 (AccessViolationException)。
        private static ProgressCallbackDelegate _callbackDelegateHolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[C#] Application started. Setting up C++ callback...");

            // 4. 创建委托实例，并将其关联到我们的 C# 实现方法。
            _callbackDelegateHolder = new ProgressCallbackDelegate(MyCallbackImplementation);

            // 5. 将委托实例传递给 C++。
            //    .NET 运行时会自动将委托封送 (marshal) 为一个 C++ 可调用的函数指针。
            SetCallback(_callbackDelegateHolder);

            Console.WriteLine("[C#] Callback set. Asking C++ to start its work...");

            // 6. 调用 C++ 函数来执行工作。
            //    这个函数会在其执行过程中，从内部调用我们 C# 的回调。
            DoWorkAndNotify();

            Console.WriteLine("[C#] C++ work function has returned to main thread.");
            Console.WriteLine("[C#] Press Enter to exit.");
            Console.ReadLine();

            // 7. (可选但推荐) 在程序退出前，确保委托仍然存活。
            GC.KeepAlive(_callbackDelegateHolder);
        }

        // 8. 这是我们实际的回调方法实现。
        //    当 C++ 调用其函数指针时，这个方法会被执行。
        public static void MyCallbackImplementation(string message)
        {
            // 注意：这个回调可能在 C++ 创建的线程上被调用！
            // 在 UI 应用中，你需要将更新操作封送到 UI 线程。
            // Console.WriteLine 是线程安全的，所以在这里可以直接使用。
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"<---- [C# CALLBACK RECEIVED] Message from C++: \"{message}\" ---->");
            Console.ResetColor();
        }
    }
}
