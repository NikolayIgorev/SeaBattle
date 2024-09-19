using System;

namespace SeaBattle
{
    class Mission
    {
        Море sea;
        Random rand;

        int[,] shape =
        {
            {1, 2, 1, 3, 1, 2, 1, 3, 1, 2 },
            {2, 1, 3, 1, 2, 1, 3, 1, 2, 1 },
            {1, 3, 1, 2, 1, 3, 1, 2, 1, 3 },
            {3, 1, 2, 1, 3, 1, 2, 1, 3, 1 },
            {1, 2, 1, 3, 1, 2, 1, 3, 1, 2 },
            {2, 1, 3, 1, 2, 1, 3, 1, 2, 1 },
            {1, 3, 1, 2, 1, 3, 1, 2, 1, 3 },
            {3, 1, 2, 1, 3, 1, 2, 1, 3, 1 },
            {1, 2, 1, 3, 1, 2, 1, 3, 1, 2 },
            {2, 1, 3, 1, 2, 1, 3, 1, 2, 1 }
        };
        bool modeDanger;
        int[] shipLenght = new int[5];
        int[,] map;
        int[,] put;

        public Mission(Море sea)
        {
            this.sea = sea;
            rand = new Random();
            map = new int[Море.размерМоря.x, Море.размерМоря.y];
            put = new int[Море.размерМоря.x, Море.размерМоря.y];
            Reset();
        }

        void Reset()
        {
            shipLenght[1] = 4;
            shipLenght[2] = 3;
            shipLenght[3] = 2;
            shipLenght[4] = 1;
            //for (int x = 0; x < Море.размерМоря.x; x++)
            //    for (int y = 0; y < Море.размерМоря.y; y++)
            //        map[x, y] = 0;
            Array.Clear(map, 0, map.Length);
            Array.Clear(put, 0, put.Length);
            modeDanger = false;
        }

        public Статус Fight(out Точка target)
        {
            if (modeDanger)
                target = FightDanger();
            else
                target = FightShapes();
            Статус status = sea.Выстрел(target);
            switch (status) 
            {
                case Статус.мимо: map[target.x, target.y] = 1; break;
                case Статус.ранил: map[target.x, target.y] = 2; modeDanger = true; break;
                case Статус.убил:
                case Статус.победил:
                    map[target.x, target.y] = 2;
                    int len = MarkKilledShip(target);
                    shipLenght[len]--;
                    modeDanger = false;
                    break;
            }

            return status;
        }

        private Точка FightShapes()
        {
            InitPut();
            for (int x = 0; x < Море.размерМоря.x; x++)
                for (int y = 0; y < Море.размерМоря.y; y++)
                    if (map[x, y] == 0)
                        put[x, y] = shape[x, y];
            return RandomPut();
        }

        private Точка FightDanger()
        {
            InitPut();

            for (int x = 0; x < Море.размерМоря.x; x++)
                for (int y = 0; y < Море.размерМоря.y; y++)
                    if (map[x, y] == 2)
                    {
                        bool longer = false;
                        Точка ship = new Точка(x, y);
                        for (int length = shipLenght.Length - 1; length >= 2; length--) 
                            if (longer || shipLenght[length] > 0)
                            {
                                CheckShipDirection(ship, -1, 0, length);
                                CheckShipDirection(ship,  1, 0, length);
                                CheckShipDirection(ship,  0,-1, length);
                                CheckShipDirection(ship,  0, 1, length);
                                longer = true;
                            }
                    }

            return RandomPut();
        }

        void CheckShipDirection(Точка ship, int sx, int sy, int length)
        {
            if (Map(ship.x, ship.y) != 2) return;
            if (Map(ship.x - sx, ship.y - sy) == 2) return;
            if (sx == 0)
            {
                if (Map(ship.x - 1, ship.y) == 2) return;
                if (Map(ship.x + 1, ship.y) == 2) return;
            }
            if (sy == 0)
            {
                if (Map(ship.x, ship.y - 1) == 2) return;
                if (Map(ship.x, ship.y + 1) == 2) return;
            }
            int unknown = 0;
            int unknownJ = 0;
            for (int j = 1; j < length; j++)
            {
                int p = Map(ship.x + j * sx, ship.y + j * sy);
                if (p == 1) return;
                if (p == -1) return;
                if (p == 0)
                {
                    unknown++;
                    if (unknown == 1)
                        unknownJ = j;
                        //put[ship.x + j * sx, ship.y + j * sy]++;
                }
            }
            if (unknown >= 1)
                put[ship.x + unknownJ * sx, ship.y + unknownJ * sy]++;
        }

        int Map(int x, int y)
        {
            if (sea.НаМоре(new Точка(x, y)))
                return map[x, y];
            return -1;
        }

        private Точка RandomPut()
        {
            //ShowPUtArray();
            int max = -1;
            int qty = 0;
            for (int x = 0; x < Море.размерМоря.x; x++)
                for (int y = 0; y < Море.размерМоря.y; y++)
                    if (put[x, y] > max)
                    {
                        max = put[x, y];
                        qty = 1;
                    }
                    else if (put[x, y] == max)
                        qty++;
            int nr = rand.Next(qty);
            for (int x = 0; x < Море.размерМоря.x; x++)
                for (int y = 0; y < Море.размерМоря.y; y++)
                    if (put[x, y] == max)
                        if (nr-- == 0)
                            return new Точка(x, y);
            return new Точка();
        }

        private void InitPut()
        {
            Array.Clear(put, 0, put.Length);
        }

        private int MarkKilledShip(Точка place)
        {
            if (!sea.НаМоре(place))
                return 0;
            if (map[place.x, place.y] == 2)
            {
                map[place.x, place.y] = 3;
                int x, y;
                for (x = place.x - 1; x < place.x + 1; x++)
                    for (y = place.y - 1; y < place.y + 1; y++)
                        if (Map(x, y) == 0)
                            map[x, y] = 1;
                int lenght = 1;
                lenght += MarkKilledShip(new Точка(place.x - 1, place.y));
                lenght += MarkKilledShip(new Точка(place.x + 1, place.y    ));
                lenght += MarkKilledShip(new Точка(place.x    , place.y - 1));
                lenght += MarkKilledShip(new Точка(place.x    , place.y + 1));
                return lenght;
            }
            return 0;
        }

        private void ShowPUtArray()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int x = 0; x < Море.размерМоря.x; x++)
                for (int y = 0; y < Море.размерМоря.y; y++)
                {
                    Console.SetCursorPosition(x + 1, y + 12);
                    Console.Write(put[x, y] > 0 ? put[x, y].ToString() : " ");
                }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
