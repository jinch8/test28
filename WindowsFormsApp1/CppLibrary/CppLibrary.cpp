#include "pch.h"
#include "CppLibrary.h"
#include <iostream>
#include <thread>
#include <chrono>

static ProgressCallback g_callback = nullptr;

void SetCallback(ProgressCallback callback) {
    std::cout << "[C++] Callback function pointer has been received and stored.\n";
    g_callback = callback;
}

void DoWorkAndNotify() {
    std::cout << "[C++] Starting some long-running work...\n";

    for (int i = 1; i <= 5; ++i) {
        std::this_thread::sleep_for(std::chrono::seconds(1));

        if (g_callback != nullptr) {
            char buffer[100];
            sprintf_s(buffer, "Work progress: %d/5", i);

            g_callback(buffer);
        }
    }

    if (g_callback != nullptr) {
        g_callback("Work finished!");
    }

    std::cout << "[C++] Work has finished.\n";
}