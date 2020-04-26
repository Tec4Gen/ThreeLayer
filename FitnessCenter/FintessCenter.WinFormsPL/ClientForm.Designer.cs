namespace FintessCenter.WinFormsPL
{
    partial class ClientForm
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
            this.btnGetAllClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateCoach = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnGetByLastNameClient = new System.Windows.Forms.Button();
            this.textBoxAddLastNameClient = new System.Windows.Forms.TextBox();
            this.textAddFirstNameClient = new System.Windows.Forms.TextBox();
            this.textBoxAddMiddleNameClient = new System.Windows.Forms.TextBox();
            this.lableAddLastName = new System.Windows.Forms.Label();
            this.lableAddFirstName = new System.Windows.Forms.Label();
            this.lableAddMiddleName = new System.Windows.Forms.Label();
            this.lableAddIDCoach = new System.Windows.Forms.Label();
            this.TextBoxUpdateSubNum = new System.Windows.Forms.TextBox();
            this.lableUpdateSubNum = new System.Windows.Forms.Label();
            this.textBoxAddIdCoach = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lableUpdateIDCoach = new System.Windows.Forms.Label();
            this.textBoxDeleteSubNum = new System.Windows.Forms.TextBox();
            this.labelDeleteSubNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGetByLastNameClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAllClient
            // 
            this.btnGetAllClient.Location = new System.Drawing.Point(31, 12);
            this.btnGetAllClient.Name = "btnGetAllClient";
            this.btnGetAllClient.Size = new System.Drawing.Size(139, 29);
            this.btnGetAllClient.TabIndex = 0;
            this.btnGetAllClient.Text = "Получить всех";
            this.btnGetAllClient.UseVisualStyleBackColor = true;
            this.btnGetAllClient.Click += new System.EventHandler(this.btnGetAllClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(31, 170);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(139, 29);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCoach
            // 
            this.btnUpdateCoach.Location = new System.Drawing.Point(31, 120);
            this.btnUpdateCoach.Name = "btnUpdateCoach";
            this.btnUpdateCoach.Size = new System.Drawing.Size(139, 29);
            this.btnUpdateCoach.TabIndex = 2;
            this.btnUpdateCoach.Text = "Обновить тренера";
            this.btnUpdateCoach.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(31, 82);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(139, 29);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnGetByLastNameClient
            // 
            this.btnGetByLastNameClient.Location = new System.Drawing.Point(31, 47);
            this.btnGetByLastNameClient.Name = "btnGetByLastNameClient";
            this.btnGetByLastNameClient.Size = new System.Drawing.Size(139, 29);
            this.btnGetByLastNameClient.TabIndex = 4;
            this.btnGetByLastNameClient.Text = "Найти по фамилии";
            this.btnGetByLastNameClient.UseVisualStyleBackColor = true;
            // 
            // textBoxAddLastNameClient
            // 
            this.textBoxAddLastNameClient.Location = new System.Drawing.Point(193, 175);
            this.textBoxAddLastNameClient.Name = "textBoxAddLastNameClient";
            this.textBoxAddLastNameClient.Size = new System.Drawing.Size(102, 20);
            this.textBoxAddLastNameClient.TabIndex = 5;
            this.textBoxAddLastNameClient.Tag = "";
            // 
            // textAddFirstNameClient
            // 
            this.textAddFirstNameClient.Location = new System.Drawing.Point(304, 175);
            this.textAddFirstNameClient.Name = "textAddFirstNameClient";
            this.textAddFirstNameClient.Size = new System.Drawing.Size(92, 20);
            this.textAddFirstNameClient.TabIndex = 6;
            // 
            // textBoxAddMiddleNameClient
            // 
            this.textBoxAddMiddleNameClient.Location = new System.Drawing.Point(402, 175);
            this.textBoxAddMiddleNameClient.Name = "textBoxAddMiddleNameClient";
            this.textBoxAddMiddleNameClient.Size = new System.Drawing.Size(92, 20);
            this.textBoxAddMiddleNameClient.TabIndex = 7;
            // 
            // lableAddLastName
            // 
            this.lableAddLastName.AutoSize = true;
            this.lableAddLastName.Location = new System.Drawing.Point(216, 159);
            this.lableAddLastName.Name = "lableAddLastName";
            this.lableAddLastName.Size = new System.Drawing.Size(56, 13);
            this.lableAddLastName.TabIndex = 9;
            this.lableAddLastName.Text = "Фамилия";
            // 
            // lableAddFirstName
            // 
            this.lableAddFirstName.AutoSize = true;
            this.lableAddFirstName.Location = new System.Drawing.Point(328, 159);
            this.lableAddFirstName.Name = "lableAddFirstName";
            this.lableAddFirstName.Size = new System.Drawing.Size(29, 13);
            this.lableAddFirstName.TabIndex = 10;
            this.lableAddFirstName.Text = "Имя";
            // 
            // lableAddMiddleName
            // 
            this.lableAddMiddleName.AutoSize = true;
            this.lableAddMiddleName.Location = new System.Drawing.Point(418, 159);
            this.lableAddMiddleName.Name = "lableAddMiddleName";
            this.lableAddMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lableAddMiddleName.TabIndex = 11;
            this.lableAddMiddleName.Text = "Отчество";
            // 
            // lableAddIDCoach
            // 
            this.lableAddIDCoach.AutoSize = true;
            this.lableAddIDCoach.Location = new System.Drawing.Point(500, 159);
            this.lableAddIDCoach.Name = "lableAddIDCoach";
            this.lableAddIDCoach.Size = new System.Drawing.Size(60, 13);
            this.lableAddIDCoach.TabIndex = 12;
            this.lableAddIDCoach.Text = "Id тренера";
            // 
            // TextBoxUpdateSubNum
            // 
            this.TextBoxUpdateSubNum.Location = new System.Drawing.Point(193, 125);
            this.TextBoxUpdateSubNum.Name = "TextBoxUpdateSubNum";
            this.TextBoxUpdateSubNum.Size = new System.Drawing.Size(102, 20);
            this.TextBoxUpdateSubNum.TabIndex = 13;
            this.TextBoxUpdateSubNum.Tag = "";
            // 
            // lableUpdateSubNum
            // 
            this.lableUpdateSubNum.AutoSize = true;
            this.lableUpdateSubNum.Location = new System.Drawing.Point(301, 128);
            this.lableUpdateSubNum.Name = "lableUpdateSubNum";
            this.lableUpdateSubNum.Size = new System.Drawing.Size(105, 13);
            this.lableUpdateSubNum.TabIndex = 14;
            this.lableUpdateSubNum.Text = "Номер абонимента";
            // 
            // textBoxAddIdCoach
            // 
            this.textBoxAddIdCoach.Location = new System.Drawing.Point(500, 175);
            this.textBoxAddIdCoach.Name = "textBoxAddIdCoach";
            this.textBoxAddIdCoach.Size = new System.Drawing.Size(60, 20);
            this.textBoxAddIdCoach.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lableUpdateIDCoach
            // 
            this.lableUpdateIDCoach.AutoSize = true;
            this.lableUpdateIDCoach.Location = new System.Drawing.Point(478, 128);
            this.lableUpdateIDCoach.Name = "lableUpdateIDCoach";
            this.lableUpdateIDCoach.Size = new System.Drawing.Size(60, 13);
            this.lableUpdateIDCoach.TabIndex = 17;
            this.lableUpdateIDCoach.Text = "Id тренера";
            // 
            // textBoxDeleteSubNum
            // 
            this.textBoxDeleteSubNum.Location = new System.Drawing.Point(193, 88);
            this.textBoxDeleteSubNum.Name = "textBoxDeleteSubNum";
            this.textBoxDeleteSubNum.Size = new System.Drawing.Size(102, 20);
            this.textBoxDeleteSubNum.TabIndex = 18;
            this.textBoxDeleteSubNum.Tag = "";
            // 
            // labelDeleteSubNum
            // 
            this.labelDeleteSubNum.AutoSize = true;
            this.labelDeleteSubNum.Location = new System.Drawing.Point(301, 91);
            this.labelDeleteSubNum.Name = "labelDeleteSubNum";
            this.labelDeleteSubNum.Size = new System.Drawing.Size(105, 13);
            this.labelDeleteSubNum.TabIndex = 19;
            this.labelDeleteSubNum.Text = "Номер абонимента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Фамилия";
            // 
            // textBoxGetByLastNameClient
            // 
            this.textBoxGetByLastNameClient.Location = new System.Drawing.Point(193, 52);
            this.textBoxGetByLastNameClient.Name = "textBoxGetByLastNameClient";
            this.textBoxGetByLastNameClient.Size = new System.Drawing.Size(102, 20);
            this.textBoxGetByLastNameClient.TabIndex = 20;
            this.textBoxGetByLastNameClient.Tag = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGetByLastNameClient);
            this.Controls.Add(this.labelDeleteSubNum);
            this.Controls.Add(this.textBoxDeleteSubNum);
            this.Controls.Add(this.lableUpdateIDCoach);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxAddIdCoach);
            this.Controls.Add(this.lableUpdateSubNum);
            this.Controls.Add(this.TextBoxUpdateSubNum);
            this.Controls.Add(this.lableAddIDCoach);
            this.Controls.Add(this.lableAddMiddleName);
            this.Controls.Add(this.lableAddFirstName);
            this.Controls.Add(this.lableAddLastName);
            this.Controls.Add(this.textBoxAddMiddleNameClient);
            this.Controls.Add(this.textAddFirstNameClient);
            this.Controls.Add(this.textBoxAddLastNameClient);
            this.Controls.Add(this.btnGetByLastNameClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateCoach);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnGetAllClient);
            this.MaximumSize = new System.Drawing.Size(610, 250);
            this.MinimumSize = new System.Drawing.Size(610, 250);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateCoach;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnGetByLastNameClient;
        private System.Windows.Forms.TextBox textBoxAddLastNameClient;
        private System.Windows.Forms.TextBox textAddFirstNameClient;
        private System.Windows.Forms.TextBox textBoxAddMiddleNameClient;
        private System.Windows.Forms.Label lableAddLastName;
        private System.Windows.Forms.Label lableAddFirstName;
        private System.Windows.Forms.Label lableAddMiddleName;
        private System.Windows.Forms.Label lableAddIDCoach;
        private System.Windows.Forms.TextBox TextBoxUpdateSubNum;
        private System.Windows.Forms.Label lableUpdateSubNum;
        private System.Windows.Forms.TextBox textBoxAddIdCoach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lableUpdateIDCoach;
        private System.Windows.Forms.TextBox textBoxDeleteSubNum;
        private System.Windows.Forms.Label labelDeleteSubNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGetByLastNameClient;
    }
}