namespace SeaBattle
{
    class Корабль
    {
        int попаданий;
        public Точка[] палуба { get; private set; }
        
        public Корабль(Точка[] палуба)
        {
            this.палуба = палуба;
            попаданий = 0;
        }

        public Статус Выстрел(Точка t)
        {
            for (int j = 0; j < палуба.Length; j++)
                if (палуба[j].x == t.x && палуба[j].y == t.y) 
                {
                    попаданий++;
                    if (попаданий == палуба.Length)
                        return Статус.убил;
                    else
                        return Статус.ранил;
                }
            return Статус.мимо;
        }
    }
}
