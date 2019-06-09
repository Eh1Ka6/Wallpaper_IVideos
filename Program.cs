using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Drawing;
using System.Text;
using System.Threading;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using System.Diagnostics;


using System.Runtime.InteropServices;
namespace Player
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
          

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            
            

                Application.Run(new MainForm());
            
               
            
            
        }
        static void PrintVisibleWindowHandles(IntPtr hwnd, int maxLevel = -1, int level = 0)
        {
            bool isVisible = W32.IsWindowVisible(hwnd);

            if (isVisible && (maxLevel == -1 || level <= maxLevel))
            {
                StringBuilder className = new StringBuilder(256);
                W32.GetClassName(hwnd, className, className.Capacity);

                StringBuilder windowTitle = new StringBuilder(256);
                W32.GetWindowText(hwnd, windowTitle, className.Capacity);

                Console.WriteLine("".PadLeft(level * 2) + "0x{0:X8} \"{1}\" {2}", hwnd.ToInt64(), windowTitle, className);

                level++;

                // Enumerates all child windows of the current window
                W32.EnumChildWindows(hwnd, new W32.EnumWindowsProc((childhandle, childparamhandle) =>
                {
                    PrintVisibleWindowHandles(childhandle, maxLevel, level);
                    return true;
                }), IntPtr.Zero);
            }
        }
        static void PrintVisibleWindowHandles(int maxLevel = -1)
        {
            // Enumerates all existing top window handles. This includes open and visible windows, as well as invisible windows.
            W32.EnumWindows(new W32.EnumWindowsProc((tophandle, topparamhandle) =>
            {
                PrintVisibleWindowHandles(tophandle, maxLevel);
                return true;
            }), IntPtr.Zero);
        }
    }
}
