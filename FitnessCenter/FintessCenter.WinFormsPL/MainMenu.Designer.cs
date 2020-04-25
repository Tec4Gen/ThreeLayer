namespace FintessCenter.WinFormsPL
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.spliterMainMenu = new System.Windows.Forms.SplitContainer();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnClient = new System.Windows.Forms.Button();
            this.btnCoach = new System.Windows.Forms.Button();
            this.bntHall = new System.Windows.Forms.Button();
            this.btnLessons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spliterMainMenu)).BeginInit();
            this.spliterMainMenu.Panel1.SuspendLayout();
            this.spliterMainMenu.Panel2.SuspendLayout();
            this.spliterMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(871, 461);
            this.webBrowser1.TabIndex = 0;
            // 
            // spliterMainMenu
            // 
            this.spliterMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spliterMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spliterMainMenu.IsSplitterFixed = true;
            this.spliterMainMenu.Location = new System.Drawing.Point(0, 0);
            this.spliterMainMenu.Name = "spliterMainMenu";
            // 
            // spliterMainMenu.Panel1
            // 
            this.spliterMainMenu.Panel1.Controls.Add(this.btnLessons);
            this.spliterMainMenu.Panel1.Controls.Add(this.bntHall);
            this.spliterMainMenu.Panel1.Controls.Add(this.btnCoach);
            this.spliterMainMenu.Panel1.Controls.Add(this.BtnClient);
            // 
            // spliterMainMenu.Panel2
            // 
            this.spliterMainMenu.Panel2.Controls.Add(this.MainGrid);
            this.spliterMainMenu.Size = new System.Drawing.Size(871, 461);
            this.spliterMainMenu.SplitterDistance = 222;
            this.spliterMainMenu.TabIndex = 1;
            this.spliterMainMenu.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainGrid.Location = new System.Drawing.Point(0, 0);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(643, 459);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Абонимент";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Тренер";
            this.Column6.Name = "Column6";
            // 
            // BtnClient
            // 
            this.BtnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClient.Location = new System.Drawing.Point(0, 0);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(220, 55);
            this.BtnClient.TabIndex = 0;
            this.BtnClient.Text = "Клиенты";
            this.BtnClient.UseVisualStyleBackColor = true;
            // 
            // btnCoach
            // 
            this.btnCoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoach.Location = new System.Drawing.Point(0, 55);
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.Size = new System.Drawing.Size(220, 55);
            this.btnCoach.TabIndex = 1;
            this.btnCoach.Text = "Тренеры";
            this.btnCoach.UseVisualStyleBackColor = true;
            // 
            // bntHall
            // 
            this.bntHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntHall.Location = new System.Drawing.Point(0, 110);
            this.bntHall.Name = "bntHall";
            this.bntHall.Size = new System.Drawing.Size(220, 55);
            this.bntHall.TabIndex = 2;
            this.bntHall.Text = "Залы";
            this.bntHall.UseVisualStyleBackColor = true;
            // 
            // btnLessons
            // 
            this.btnLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLessons.Location = new System.Drawing.Point(0, 165);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(220, 55);
            this.btnLessons.TabIndex = 3;
            this.btnLessons.Text = "Занятия";
            this.btnLessons.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 461);
            this.Controls.Add(this.spliterMainMenu);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(887, 500);
            this.MinimumSize = new System.Drawing.Size(887, 500);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.spliterMainMenu.Panel1.ResumeLayout(false);
            this.spliterMainMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spliterMainMenu)).EndInit();
            this.spliterMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer spliterMainMenu;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button bntHall;
        private System.Windows.Forms.Button btnCoach;
        private System.Windows.Forms.Button BtnClient;
    }
}