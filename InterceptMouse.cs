using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Player
{
   
    class InterceptMouse
    {
        bool disposed = false;
        private static LowLevelMouseProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;
        private static MainForm Mf;
        public InterceptMouse(MainForm Main)

        {
            Mf = Main;
            _hookID = SetHook(_proc);

           // Application.Run();

            

        }


        private IntPtr SetHook(LowLevelMouseProc proc)

        {

            using (Process curProcess = Process.GetCurrentProcess())

            using (ProcessModule curModule = curProcess.MainModule)

            {

                return SetWindowsHookEx(WH_MOUSE_LL, proc,

                    GetModuleHandle(curModule.ModuleName), 0);

            }

        }


        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);


        private static IntPtr HookCallback(

            int nCode, IntPtr wParam, IntPtr lParam)

        {

            if (nCode >= 0 &&

                MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)

            {

                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                // Do we reach panel postion on  x axis 
                // Which button on y axis 
                if (hookStruct.pt.x > 1030 && hookStruct.pt.x < 1180)
                {
                    if (hookStruct.pt.y > 107 && hookStruct.pt.y < 165 )
                    {
                        Console.WriteLine(hookStruct.pt.x + ", " + hookStruct.pt.y);
                        object sender = new object();
                        EventArgs e = new EventArgs();
                        Mf.Button1_Click(sender, e );
                    }

                    if (hookStruct.pt.y > 207 && hookStruct.pt.y < 268)
                    {
                        Console.WriteLine(hookStruct.pt.x + ", " + hookStruct.pt.y);
                        object sender = new object();
                        EventArgs e = new EventArgs();
                        Mf.Button2_Click(sender, e);
                    }
                }

                Console.WriteLine(hookStruct.pt.x + ", " + hookStruct.pt.y);

            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);

        }


        private const int WH_MOUSE_LL = 14;


        private enum MouseMessages

        {

            WM_LBUTTONDOWN = 0x0201,

            WM_LBUTTONUP = 0x0202,

            WM_MOUSEMOVE = 0x0200,

            WM_MOUSEWHEEL = 0x020A,

            WM_RBUTTONDOWN = 0x0204,

            WM_RBUTTONUP = 0x0205

        }


        [StructLayout(LayoutKind.Sequential)]

        private struct POINT

        {

            public int x;

            public int y;

        }


        [StructLayout(LayoutKind.Sequential)]

        private struct MSLLHOOKSTRUCT

        {

            public POINT pt;

            public uint mouseData;

            public uint flags;

            public uint time;

            public IntPtr dwExtraInfo;

        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr SetWindowsHookEx(int idHook,

            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool UnhookWindowsHookEx(IntPtr hhk);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,

            IntPtr wParam, IntPtr lParam);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr GetModuleHandle(string lpModuleName);



        public void Dispose()
        {
            
            this.Dispose(true);
            GC.SuppressFinalize(this);
            
        }
        private void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                UnhookWindowsHookEx(_hookID);
                ////Number of instance you want to dispose
            }
        }
    }

   
  
}
  
