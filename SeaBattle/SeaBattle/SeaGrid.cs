using System.Drawing;
using System.Windows.Forms;

namespace SeaBattle
{
    class SeaGrid
    {
        DataGridView grid;

        static string abc = "РЕСПУБЛИКА";// "АБСДЕЖЗИКЛМНОПРСТУФСХШЩЭЮЯ";

        Color colorBack = Color.DarkSeaGreen;
        Color[] colorShip =
        {
            Color.Purple,
            Color.Purple, Color.Purple,
            Color.Purple, Color.Purple, Color.Purple,
            Color.Purple, Color.Purple, Color.Purple, Color.Purple
        };

        Color[] color_Fight =
        {
            Color.DarkSeaGreen, Color.SeaGreen, Color.Orange, Color.OrangeRed, Color.Magenta
        };

        public SeaGrid(DataGridView grid)
        {
            this.grid = grid;
            InitGrid();
        }

        void InitGrid()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.DefaultCellStyle.BackColor = colorBack;
            for (int x = 0; x < Море.размерМоря.x; x++)
                grid.Columns.Add("col_" + x.ToString(), abc.Substring(x, 1));

            for (int y = 0; y < Море.размерМоря.y; y++)
            {
                grid.Rows.Add();
                grid.Rows[y].HeaderCell.Value = (y + 1).ToString();
            }
            grid.Height = Море.размерМоря.y * grid.Rows[0].Height + grid.ColumnHeadersHeight + 2;
            grid.ClearSelection();
        }

        public void ShowShip(Точка place, int nr)
        {
            if (nr < 0)
                grid[place.x, place.y].Style.BackColor = colorBack;
            else
                grid[place.x, place.y].Style.BackColor = colorShip[nr];
            grid.ClearSelection();
        }

        public void ShowFight(Точка place, Статус status)
        {
            grid.ClearSelection();
            grid[place.x, place.y].Style.BackColor = color_Fight[(int)status];
        }

        public Точка[] SelectedCells()
        {
            if (grid.SelectedCells.Count == 0) return null;

            Точка[] ship = new Точка[grid.SelectedCells.Count];
            int j = 0;
            foreach (DataGridViewCell cell in grid.SelectedCells)
                ship[j++] = new Точка(cell.ColumnIndex, cell.RowIndex);
            grid.ClearSelection();
            return ship;
        }
    }
}
