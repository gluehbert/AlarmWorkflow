﻿using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;

namespace AlarmWorkflow.Windows.UI
{
    static class Helper
    {
        /// <summary>
        /// Convenience wrapper for the "Dispatcher.Invoke()" method which does not support lambdas.
        /// </summary>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        internal static void Invoke(this Dispatcher dispatcher, Action action)
        {
            dispatcher.Invoke(action);
        }

        internal static double Limit(double min, double max, double value)
        {
            if (value < min)
            {
                return min;
            }
            if (value > max)
            {
                return max;
            }
            return value;
        }

        internal static System.Drawing.Rectangle GetWindowRect(Window window)
        {
            IntPtr ptr = new WindowInteropHelper(window).Handle;
            RECT rect = new RECT();
            GetWindowRect(ptr, ref rect);

            return new System.Drawing.Rectangle(rect.Left, rect.Top, (rect.Right - rect.Left), (rect.Bottom - rect.Top));
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }
}
