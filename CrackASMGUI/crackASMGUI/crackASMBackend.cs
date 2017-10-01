/*
	crackASMBackend.cs
	Tristan Van Cise
	CS 301 Assembly Language Programming
	09/25/2017
    Import from DLL
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using crackASMGUI;

namespace crackASMGUI
{
    public class crackASMBackend
    {
     
        /// The main entry point for the application.

        //Import a function from specified DLL, C# treats this as a static, unmanaged code, entry point
        //unmanaged code is code that C# is not responsible for
        //c++ file exports the functions, here we import them to use in the GUI

        [System.Runtime.InteropServices.DllImport("CrackASM.dll")]
        public static extern int Addition(int x, int y);

        [System.Runtime.InteropServices.DllImport("CrackASM.dll")]
        public static extern int Subtraction(int x, int y);

        [System.Runtime.InteropServices.DllImport("CrackASM.dll")]
        public static extern int Multiplication(int x, int y);

        [System.Runtime.InteropServices.DllImport("CrackASM.dll")]
        public static extern int Division(int x, int y);



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new crackASMGUI());
        }
    }

    
}
