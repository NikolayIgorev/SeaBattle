using System;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class FormGame : Form
    {
        Редактор seaUser;
        Редактор seaComp;

        SeaGrid GridUser;
        SeaGrid GridComp;

        Mission mission;

        enum Mode 
        { 
            EditShips,
            PlayUser,
            PlayComp,
            Finish
        }

        Mode mode;

        public FormGame()
        {
            InitializeComponent();
            seaUser = new Редактор();
            seaUser.showShip = ShowUserShip;
            seaUser.showFight = ShowUserFight;

            seaComp = new Редактор();
            seaComp.showShip = ShowCompShip;
            seaComp.showFight = ShowCompFight;

            GridUser = new SeaGrid(gridUser);
            GridComp = new SeaGrid(gridComp);
            Restart();
        }

        void Restart()
        {
            mode = Mode.EditShips;

            seaUser.Сброс();
            seaComp.Сброс();

            seaComp.ПоставитьРовно();
            ShowUnplacedShips();

            MenuInterfeis(true);
        }

        void ShowUserShip(Точка place, int nr)
        {
            GridUser.ShowShip(place, nr);
        }

        void ShowCompShip(Точка place, int nr)
        {
            if (mode == Mode.EditShips)
                GridComp.ShowShip(place, nr);
        }

        void ShowUserFight(Точка place, Статус status)
        {
            GridUser.ShowFight(place, status);
        }

        void ShowCompFight(Точка place, Статус status)
        {
            GridComp.ShowFight(place, status);
        }

        private void gridUser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PlaceShip();
            gridUser.ClearSelection();
        }

        void PlaceShip()
        {
            if (mode != Mode.EditShips) return;
            Точка[] ship = GridUser.SelectedCells();
            if (ship == null) return;
            if (ship.Length == 1)
                seaUser.ОчиститьТочку(ship[0]);
            seaUser.ПоставитьПоТочкам(ship);
            ShowUnplacedShips();
        }

        void ShowUnplacedShips()
        {
            seaComp.ПоставитьРовно();
            for (int j = 0; j < Море.всегоКораблей; j++)
                if (!seaUser.НетКорабля(j))
                    seaComp.УбратьКорабль(j);
            menuNewGame.Visible = (seaUser.создано == Море.всегоКораблей);
        }

        private void gridUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                PlaceShip();
        }

        private void menuRandom_Click(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips) return;
            seaUser.ПоставитьСлучайно();
            ShowUnplacedShips();
        }

        private void menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips) return;
            seaUser.Сброс();
            ShowUnplacedShips();
        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips) return;

            if(seaUser.создано == Море.всегоКораблей)
            {
                mode = Mode.PlayUser;
                seaComp.ПоставитьСлучайно();
                mission = new Mission(seaUser);
                MenuInterfeis(false);
            }
        }

        private void menuRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void MenuInterfeis(bool b)
        {
            menuClear.Enabled = b;
            menuNewGame.Enabled = b;
            menuRandom.Enabled = b;

            menuRestart.Enabled = !b;
            timer.Enabled = !b;
        }

        private void gridComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mode != Mode.PlayUser) return;
            Статус status = seaComp.Выстрел(new Точка(e.ColumnIndex, e.RowIndex));

            switch (status)
            {
                case Статус.неизвестно:
                case Статус.мимо:
                    mode = Mode.PlayComp;
                    break;
                case Статус.ранил:
                case Статус.убил:
                    mode = Mode.PlayUser;
                    break;
                case Статус.победил:
                    mode = Mode.Finish;
                    WinUser();
                    break;
            }

            //while(mode == Mode.PlayComp)
            //{
            //    CompFight();
            //}
        }

        void CompFight()
        {
            Точка point;
            Статус status = mission.Fight(out point);

            switch (status)
            {
                case Статус.неизвестно:
                case Статус.мимо:
                    mode = Mode.PlayUser;
                    break;
                case Статус.ранил:
                case Статус.убил:
                    mode = Mode.PlayComp;
                    break;
                case Статус.победил:
                    mode = Mode.Finish;
                    WinComp();
                    break;
            }
        }

        private void WinUser()
        {
            MessageBox.Show("Вы потапили все корабли компютера", " Ура Победа");
        }

        private void WinComp()
        {
            MessageBox.Show("Компютер потапил весь ваш флот", " Компютер Победа");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (mode == Mode.PlayComp)
                CompFight();
        }
    }
}
