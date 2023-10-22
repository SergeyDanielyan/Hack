using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public static class FormInfo
    {
        public static int numberOfPlayers { get; set; }
        public static int[] userPoints { get; set; }
        public static bool questionClass { get; set; }
        public static bool startOfGame = true;
        public static int number = 0;
        public static int[] fieldCell { get; set; }
        public static bool cubik = true;
    }
}
