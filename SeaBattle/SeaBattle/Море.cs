using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    delegate void deShowShip(Точка place, int nr);
    delegate void deShowFight(Точка place, Статус status);

    class Море
    {
        public static Точка размерМоря = new Точка(10, 10);
        public static int всегоКораблей = 10;

        public deShowShip showShip;
        public deShowFight showFight;

        protected int[,] картаКораблей;
        protected Статус[,] картаПопаданий;

        protected Корабль[] корабль;
        public int создано { get; protected set; }
        public int убито { get; protected set; }

        public Море()
        {
            картаКораблей = new int[размерМоря.x, размерМоря.y];
            картаПопаданий = new Статус[размерМоря.x, размерМоря.y];
            корабль = new Корабль[всегоКораблей];
        }

        public Статус КартаПопаданий(Точка t)
        {
            if (НаМоре(t))
                return картаПопаданий[t.x, t.y];
            return Статус.неизвестно;
        }

        public bool НаМоре(Точка t)
        {
            return (t.x >= 0 && t.x < размерМоря.x && t.y >= 0 && t.y < размерМоря.y);
        }

        public Статус Выстрел(Точка t)
        {
            if (!НаМоре(t)) return Статус.неизвестно;
            if (картаПопаданий[t.x, t.y] != Статус.неизвестно)
                return картаПопаданий[t.x, t.y];
            Статус статус;
            if (картаКораблей[t.x, t.y] == -1)
            {
                картаПопаданий[t.x, t.y] = Статус.мимо;
                статус = Статус.мимо;
            }
            else
                статус = корабль[картаКораблей[t.x, t.y]].Выстрел(t);
            картаПопаданий[t.x, t.y] = статус;
            if(статус == Статус.убил)
            {
                убито++;
                if (убито >= создано)
                    статус = Статус.победил;
            }
            showFight(t, статус);
            return статус;
        }
    }
}
