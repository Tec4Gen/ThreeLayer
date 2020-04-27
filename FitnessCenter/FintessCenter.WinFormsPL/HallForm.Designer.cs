namespace FintessCenter.WinFormsPL
{
    partial class HallForm
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
            this.btnGetAllHall = new System.Windows.Forms.Button();
            this.btnGetByHallName = new System.Windows.Forms.Button();
            this.btnDeleteHallName = new System.Windows.Forms.Button();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.textBoxAddNameHall = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionHall = new System.Windows.Forms.TextBox();
            this.lableAddHallName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameHall = new System.Windows.Forms.TextBox();
            this.LastNameCoach = new System.Windows.Forms.Label();
            this.textBoxGetByNameHall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAllHall
            // 
            this.btnGetAllHall.Location = new System.Drawing.Point(31, 12);
            this.btnGetAllHall.Name = "btnGetAllHall";
            this.btnGetAllHall.Size = new System.Drawing.Size(139, 29);
            this.btnGetAllHall.TabIndex = 1;
            this.btnGetAllHall.Text = "Получить все залы";
            this.btnGetAllHall.UseVisualStyleBackColor = true;
            this.btnGetAllHall.Click += new System.EventHandler(this.btnGetAllHall_Click);
            // 
            // btnGetByHallName
            // 
            this.btnGetByHallName.Location = new System.Drawing.Point(31, 47);
            this.btnGetByHallName.Name = "btnGetByHallName";
            this.btnGetByHallName.Size = new System.Drawing.Size(139, 29);
            this.btnGetByHallName.TabIndex = 5;
            this.btnGetByHallName.Text = "Найти по названию";
            this.btnGetByHallName.UseVisualStyleBackColor = true;
            this.btnGetByHallName.Click += new System.EventHandler(this.btnGetByHallName_Click);
            // 
            // btnDeleteHallName
            // 
            this.btnDeleteHallName.Location = new System.Drawing.Point(31, 82);
            this.btnDeleteHallName.Name = "btnDeleteHallName";
            this.btnDeleteHallName.Size = new System.Drawing.Size(139, 29);
            this.btnDeleteHallName.TabIndex = 22;
            this.btnDeleteHallName.Text = "Удалить зал";
            this.btnDeleteHallName.UseVisualStyleBackColor = true;
            this.btnDeleteHallName.Click += new System.EventHandler(this.btnDeleteHallName_Click);
            // 
            // btnAddHall
            // 
            this.btnAddHall.Location = new System.Drawing.Point(31, 170);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(139, 29);
            this.btnAddHall.TabIndex = 23;
            this.btnAddHall.Text = "Добавить зал";
            this.btnAddHall.UseVisualStyleBackColor = true;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // textBoxAddNameHall
            // 
            this.textBoxAddNameHall.Location = new System.Drawing.Point(192, 175);
            this.textBoxAddNameHall.Name = "textBoxAddNameHall";
            this.textBoxAddNameHall.Size = new System.Drawing.Size(124, 20);
            this.textBoxAddNameHall.TabIndex = 24;
            this.textBoxAddNameHall.Tag = "";
            // 
            // textBoxDescriptionHall
            // 
            this.textBoxDescriptionHall.Location = new System.Drawing.Point(322, 175);
            this.textBoxDescriptionHall.Name = "textBoxDescriptionHall";
            this.textBoxDescriptionHall.Size = new System.Drawing.Size(260, 20);
            this.textBoxDescriptionHall.TabIndex = 25;
            this.textBoxDescriptionHall.Tag = "";
            // 
            // lableAddHallName
            // 
            this.lableAddHallName.AutoSize = true;
            this.lableAddHallName.Location = new System.Drawing.Point(213, 159);
            this.lableAddHallName.Name = "lableAddHallName";
            this.lableAddHallName.Size = new System.Drawing.Size(84, 13);
            this.lableAddHallName.TabIndex = 26;
            this.lableAddHallName.Text = "Название зала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Описание";
            // 
            // textBoxNameHall
            // 
            this.textBoxNameHall.Location = new System.Drawing.Point(192, 87);
            this.textBoxNameHall.Name = "textBoxNameHall";
            this.textBoxNameHall.Size = new System.Drawing.Size(86, 20);
            this.textBoxNameHall.TabIndex = 36;
            // 
            // LastNameCoach
            // 
            this.LastNameCoach.AutoSize = true;
            this.LastNameCoach.Location = new System.Drawing.Point(284, 90);
            this.LastNameCoach.Name = "LastNameCoach";
            this.LastNameCoach.Size = new System.Drawing.Size(84, 13);
            this.LastNameCoach.TabIndex = 42;
            this.LastNameCoach.Text = "Название зала";
            // 
            // textBoxGetByNameHall
            // 
            this.textBoxGetByNameHall.Location = new System.Drawing.Point(192, 52);
            this.textBoxGetByNameHall.Name = "textBoxGetByNameHall";
            this.textBoxGetByNameHall.Size = new System.Drawing.Size(86, 20);
            this.textBoxGetByNameHall.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Название зала";
            // 
            // HallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGetByNameHall);
            this.Controls.Add(this.LastNameCoach);
            this.Controls.Add(this.textBoxNameHall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lableAddHallName);
            this.Controls.Add(this.textBoxDescriptionHall);
            this.Controls.Add(this.textBoxAddNameHall);
            this.Controls.Add(this.btnAddHall);
            this.Controls.Add(this.btnDeleteHallName);
            this.Controls.Add(this.btnGetByHallName);
            this.Controls.Add(this.btnGetAllHall);
            this.Name = "HallForm";
            this.Text = "HallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllHall;
        private System.Windows.Forms.Button btnGetByHallName;
        private System.Windows.Forms.Button btnDeleteHallName;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.TextBox textBoxAddNameHall;
        private System.Windows.Forms.TextBox textBoxDescriptionHall;
        private System.Windows.Forms.Label lableAddHallName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameHall;
        private System.Windows.Forms.Label LastNameCoach;
        private System.Windows.Forms.TextBox textBoxGetByNameHall;
        private System.Windows.Forms.Label label2;
    }
}