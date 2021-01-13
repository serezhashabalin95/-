using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publikaciy
{
    static class Program
    {

        public static Form4 f1; // переменная, которая будет содержать ссылку на форму Form1
        public static Form4 f2; // переменная, которая будет содержать ссылку на форму Form2
        public static Form4 f3; // переменная, которая будет содержать ссылку на форму Form3
        public static Form4 f4; // переменная, которая будет содержать ссылку на форму Form4
        public static Form4 f5; // переменная, которая будет содержать ссылку на форму Form5
        public static Form4 f6; // переменная, которая будет содержать ссылку на форму Form6

        [STAThread]
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
