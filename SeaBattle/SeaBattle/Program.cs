using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    enum Статус
    {
        неизвестно,
        мимо,
        ранил,
        убил,
        победил
    }

    struct Точка
    {
        public int x;
        public int y;
        public Точка(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

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
            Application.Run(new FormGame());
        }
    }
}
