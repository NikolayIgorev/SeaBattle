
namespace SeaBattle
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.gridComp = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComp)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClear,
            this.menuRandom,
            this.menuRestart,
            this.menuNewGame});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(801, 40);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDoubleClick);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(144, 36);
            this.menuClear.Text = "Очистить Море";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // menuRandom
            // 
            this.menuRandom.Name = "menuRandom";
            this.menuRandom.Size = new System.Drawing.Size(220, 36);
            this.menuRandom.Text = "Случайная расстоновка";
            this.menuRandom.Click += new System.EventHandler(this.menuRandom_Click);
            // 
            // menuRestart
            // 
            this.menuRestart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRestart.Enabled = false;
            this.menuRestart.Name = "menuRestart";
            this.menuRestart.Size = new System.Drawing.Size(143, 36);
            this.menuRestart.Text = "Начать заново";
            this.menuRestart.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuRestart.Click += new System.EventHandler(this.menuRestart_Click);
            // 
            // menuNewGame
            // 
            this.menuNewGame.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(120, 36);
            this.menuNewGame.Text = "Новая ИГРА";
            this.menuNewGame.Click += new System.EventHandler(this.menuNewGame_Click);
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.AllowUserToDeleteRows = false;
            this.gridUser.AllowUserToOrderColumns = true;
            this.gridUser.AllowUserToResizeColumns = false;
            this.gridUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridUser.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUser.ColumnHeadersHeight = 30;
            this.gridUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridUser.Location = new System.Drawing.Point(0, 40);
            this.gridUser.Name = "gridUser";
            this.gridUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUser.RowHeadersWidth = 50;
            this.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridUser.ShowCellErrors = false;
            this.gridUser.ShowCellToolTips = false;
            this.gridUser.ShowEditingIcon = false;
            this.gridUser.ShowRowErrors = false;
            this.gridUser.Size = new System.Drawing.Size(400, 339);
            this.gridUser.TabIndex = 3;
            this.gridUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridUser_KeyDown);
            this.gridUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridUser_MouseUp);
            // 
            // gridComp
            // 
            this.gridComp.AllowUserToAddRows = false;
            this.gridComp.AllowUserToDeleteRows = false;
            this.gridComp.AllowUserToOrderColumns = true;
            this.gridComp.AllowUserToResizeColumns = false;
            this.gridComp.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridComp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridComp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridComp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridComp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridComp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridComp.ColumnHeadersHeight = 30;
            this.gridComp.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridComp.Location = new System.Drawing.Point(401, 40);
            this.gridComp.Name = "gridComp";
            this.gridComp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComp.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridComp.RowHeadersWidth = 50;
            this.gridComp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridComp.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridComp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridComp.ShowCellErrors = false;
            this.gridComp.ShowCellToolTips = false;
            this.gridComp.ShowEditingIcon = false;
            this.gridComp.ShowRowErrors = false;
            this.gridComp.Size = new System.Drawing.Size(400, 339);
            this.gridComp.TabIndex = 4;
            this.gridComp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComp_CellClick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(801, 379);
            this.Controls.Add(this.gridComp);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem menuRandom;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem menuRestart;
        private System.Windows.Forms.DataGridView gridComp;
        public System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.Timer timer;
    }
}

