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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //Import a function from specified DLL, C# treats this as a static, unmanaged code, entry point
        //unmanaged code is code that C# is not responsible for
        //c++ file exports the functions, here we import them to use in the GUI

        const string absolutePath = @"C:\\Users\\Grubs\\Documents\\Visual Studio 2017\\Projects\\CrackASM\\Debug\\CrackASM.dll";

        [System.Runtime.InteropServices.DllImport(absolutePath)]
        public static extern int Addition(int x, int y);

        [System.Runtime.InteropServices.DllImport(absolutePath)]
        public static extern int Subtraction(int x, int y);

        [System.Runtime.InteropServices.DllImport(absolutePath)]
        public static extern int Multiplication(int x, int y);

        [System.Runtime.InteropServices.DllImport(absolutePath)]
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
