#pragma once

#define CPPLIBRARY_EXPORTS

// 为 C++ 导出宏定义
#ifdef CPPLIBRARY_EXPORTS
#define CPPLIBRARY_API extern "C" __declspec(dllexport)
#else
#define CPPLIBRARY_API extern "C" __declspec(dllimport)
#endif

/**
 * @brief 定义回调函数的指针类型。
 * @param message 从 C++ 传给 C# 的消息字符串。
 * @note __stdcall 是 Windows API 中常见的调用约定。
 */
//typedef void(__stdcall* ProgressCallback)(const char* message);
typedef void(*ProgressCallback)(const char* message);

/**
 * @brief 设置回调函数。C# 将调用此函数来注册它的委托。
 * @param callback C# 传过来的回调函数指针。
 */
CPPLIBRARY_API void SetCallback(ProgressCallback callback);

/**
 * @brief 执行一项长时间的工作，并在过程中触发回调。
 */
CPPLIBRARY_API void DoWorkAndNotify();
