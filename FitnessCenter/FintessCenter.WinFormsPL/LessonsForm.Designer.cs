namespace FintessCenter.WinFormsPL
{
    partial class LessonsForm
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
            this.btnGetAllLessons = new System.Windows.Forms.Button();
            this.btnAlllessonByPhoneCoach = new System.Windows.Forms.Button();
            this.btnGetAllLessonSubNumClient = new System.Windows.Forms.Button();
            this.btnGetAllLessonsByHallName = new System.Windows.Forms.Button();
            this.btnGetLessonById = new System.Windows.Forms.Button();
            this.btnEmploymentAllHallByDate = new System.Windows.Forms.Button();
            this.btnEmploymentAllHallByDateTime = new System.Windows.Forms.Button();
            this.btnEmploymentHallByDate = new System.Windows.Forms.Button();
            this.btnEmploymentHallByDateTime = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.textBoxIdLessons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLessonByPhoneCoach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLessonBySubNumClient = new System.Windows.Forms.TextBox();
            this.labelDeleteSubNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLessonByHallName = new System.Windows.Forms.TextBox();
            this.dateTimeEmploymentAllHallByDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEmploymentAllHallByDate_ = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEmploymentAllHallByDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEmploymentHallByDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEmploymentHallByDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEmploymentHallByDate_ = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddLessonIdClient = new System.Windows.Forms.TextBox();
            this.textBoxAddLessonIdHall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeAddLessonDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAddLessonTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGetAllLessons
            // 
            this.btnGetAllLessons.Location = new System.Drawing.Point(34, 12);
            this.btnGetAllLessons.Name = "btnGetAllLessons";
            this.btnGetAllLessons.Size = new System.Drawing.Size(139, 29);
            this.btnGetAllLessons.TabIndex = 1;
            this.btnGetAllLessons.Text = "Посмотреть занятия";
            this.btnGetAllLessons.UseVisualStyleBackColor = true;
            // 
            // btnAlllessonByPhoneCoach
            // 
            this.btnAlllessonByPhoneCoach.Location = new System.Drawing.Point(34, 85);
            this.btnAlllessonByPhoneCoach.Name = "btnAlllessonByPhoneCoach";
            this.btnAlllessonByPhoneCoach.Size = new System.Drawing.Size(139, 41);
            this.btnAlllessonByPhoneCoach.TabIndex = 2;
            this.btnAlllessonByPhoneCoach.Text = "Посмотреть занятия тренера";
            this.btnAlllessonByPhoneCoach.UseVisualStyleBackColor = true;
            // 
            // btnGetAllLessonSubNumClient
            // 
            this.btnGetAllLessonSubNumClient.Location = new System.Drawing.Point(34, 132);
            this.btnGetAllLessonSubNumClient.Name = "btnGetAllLessonSubNumClient";
            this.btnGetAllLessonSubNumClient.Size = new System.Drawing.Size(139, 36);
            this.btnGetAllLessonSubNumClient.TabIndex = 3;
            this.btnGetAllLessonSubNumClient.Text = "Посмотреть занятия клиента";
            this.btnGetAllLessonSubNumClient.UseVisualStyleBackColor = true;
            // 
            // btnGetAllLessonsByHallName
            // 
            this.btnGetAllLessonsByHallName.Location = new System.Drawing.Point(34, 174);
            this.btnGetAllLessonsByHallName.Name = "btnGetAllLessonsByHallName";
            this.btnGetAllLessonsByHallName.Size = new System.Drawing.Size(139, 36);
            this.btnGetAllLessonsByHallName.TabIndex = 4;
            this.btnGetAllLessonsByHallName.Text = "Посмотреть занятия в зале";
            this.btnGetAllLessonsByHallName.UseVisualStyleBackColor = true;
            // 
            // btnGetLessonById
            // 
            this.btnGetLessonById.Location = new System.Drawing.Point(34, 47);
            this.btnGetLessonById.Name = "btnGetLessonById";
            this.btnGetLessonById.Size = new System.Drawing.Size(139, 29);
            this.btnGetLessonById.TabIndex = 5;
            this.btnGetLessonById.Text = "Найти занятие по id";
            this.btnGetLessonById.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentAllHallByDate
            // 
            this.btnEmploymentAllHallByDate.Location = new System.Drawing.Point(34, 216);
            this.btnEmploymentAllHallByDate.Name = "btnEmploymentAllHallByDate";
            this.btnEmploymentAllHallByDate.Size = new System.Drawing.Size(139, 36);
            this.btnEmploymentAllHallByDate.TabIndex = 6;
            this.btnEmploymentAllHallByDate.Text = "Занятость залов по дате";
            this.btnEmploymentAllHallByDate.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentAllHallByDateTime
            // 
            this.btnEmploymentAllHallByDateTime.Location = new System.Drawing.Point(34, 258);
            this.btnEmploymentAllHallByDateTime.Name = "btnEmploymentAllHallByDateTime";
            this.btnEmploymentAllHallByDateTime.Size = new System.Drawing.Size(139, 36);
            this.btnEmploymentAllHallByDateTime.TabIndex = 8;
            this.btnEmploymentAllHallByDateTime.Text = "Занятость залов по дате и времени";
            this.btnEmploymentAllHallByDateTime.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentHallByDate
            // 
            this.btnEmploymentHallByDate.Location = new System.Drawing.Point(34, 300);
            this.btnEmploymentHallByDate.Name = "btnEmploymentHallByDate";
            this.btnEmploymentHallByDate.Size = new System.Drawing.Size(139, 36);
            this.btnEmploymentHallByDate.TabIndex = 9;
            this.btnEmploymentHallByDate.Text = "Занятость зала по дате";
            this.btnEmploymentHallByDate.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentHallByDateTime
            // 
            this.btnEmploymentHallByDateTime.Location = new System.Drawing.Point(34, 342);
            this.btnEmploymentHallByDateTime.Name = "btnEmploymentHallByDateTime";
            this.btnEmploymentHallByDateTime.Size = new System.Drawing.Size(139, 36);
            this.btnEmploymentHallByDateTime.TabIndex = 10;
            this.btnEmploymentHallByDateTime.Text = "Занятость зала по дате и времени";
            this.btnEmploymentHallByDateTime.UseVisualStyleBackColor = true;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(34, 404);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(139, 29);
            this.btnAddLesson.TabIndex = 11;
            this.btnAddLesson.Text = "Добавить занятие";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            // 
            // textBoxIdLessons
            // 
            this.textBoxIdLessons.Location = new System.Drawing.Point(179, 52);
            this.textBoxIdLessons.Name = "textBoxIdLessons";
            this.textBoxIdLessons.Size = new System.Drawing.Size(60, 20);
            this.textBoxIdLessons.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id занятия";
            // 
            // textBoxLessonByPhoneCoach
            // 
            this.textBoxLessonByPhoneCoach.Location = new System.Drawing.Point(179, 96);
            this.textBoxLessonByPhoneCoach.Name = "textBoxLessonByPhoneCoach";
            this.textBoxLessonByPhoneCoach.Size = new System.Drawing.Size(102, 20);
            this.textBoxLessonByPhoneCoach.TabIndex = 23;
            this.textBoxLessonByPhoneCoach.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Номер телефона";
            // 
            // TextBoxLessonBySubNumClient
            // 
            this.TextBoxLessonBySubNumClient.Location = new System.Drawing.Point(179, 141);
            this.TextBoxLessonBySubNumClient.Name = "TextBoxLessonBySubNumClient";
            this.TextBoxLessonBySubNumClient.Size = new System.Drawing.Size(102, 20);
            this.TextBoxLessonBySubNumClient.TabIndex = 24;
            this.TextBoxLessonBySubNumClient.Tag = "";
            // 
            // labelDeleteSubNum
            // 
            this.labelDeleteSubNum.AutoSize = true;
            this.labelDeleteSubNum.Location = new System.Drawing.Point(287, 144);
            this.labelDeleteSubNum.Name = "labelDeleteSubNum";
            this.labelDeleteSubNum.Size = new System.Drawing.Size(105, 13);
            this.labelDeleteSubNum.TabIndex = 25;
            this.labelDeleteSubNum.Text = "Номер абонимента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Название зала";
            // 
            // textBoxLessonByHallName
            // 
            this.textBoxLessonByHallName.Location = new System.Drawing.Point(179, 183);
            this.textBoxLessonByHallName.Name = "textBoxLessonByHallName";
            this.textBoxLessonByHallName.Size = new System.Drawing.Size(60, 20);
            this.textBoxLessonByHallName.TabIndex = 26;
            // 
            // dateTimeEmploymentAllHallByDate
            // 
            this.dateTimeEmploymentAllHallByDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEmploymentAllHallByDate.Location = new System.Drawing.Point(179, 222);
            this.dateTimeEmploymentAllHallByDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentAllHallByDate.Name = "dateTimeEmploymentAllHallByDate";
            this.dateTimeEmploymentAllHallByDate.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentAllHallByDate.TabIndex = 28;
            // 
            // dateTimeEmploymentAllHallByDate_
            // 
            this.dateTimeEmploymentAllHallByDate_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEmploymentAllHallByDate_.Location = new System.Drawing.Point(179, 264);
            this.dateTimeEmploymentAllHallByDate_.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentAllHallByDate_.Name = "dateTimeEmploymentAllHallByDate_";
            this.dateTimeEmploymentAllHallByDate_.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentAllHallByDate_.TabIndex = 29;
            // 
            // dateTimeEmploymentAllHallByDateTime
            // 
            this.dateTimeEmploymentAllHallByDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEmploymentAllHallByDateTime.Location = new System.Drawing.Point(270, 264);
            this.dateTimeEmploymentAllHallByDateTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentAllHallByDateTime.Name = "dateTimeEmploymentAllHallByDateTime";
            this.dateTimeEmploymentAllHallByDateTime.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentAllHallByDateTime.TabIndex = 30;
            this.dateTimeEmploymentAllHallByDateTime.Value = new System.DateTime(2020, 4, 26, 15, 57, 15, 0);
            // 
            // dateTimeEmploymentHallByDate
            // 
            this.dateTimeEmploymentHallByDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEmploymentHallByDate.Location = new System.Drawing.Point(179, 306);
            this.dateTimeEmploymentHallByDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentHallByDate.Name = "dateTimeEmploymentHallByDate";
            this.dateTimeEmploymentHallByDate.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentHallByDate.TabIndex = 31;
            // 
            // dateTimeEmploymentHallByDateTime
            // 
            this.dateTimeEmploymentHallByDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEmploymentHallByDateTime.Location = new System.Drawing.Point(270, 348);
            this.dateTimeEmploymentHallByDateTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentHallByDateTime.Name = "dateTimeEmploymentHallByDateTime";
            this.dateTimeEmploymentHallByDateTime.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentHallByDateTime.TabIndex = 32;
            this.dateTimeEmploymentHallByDateTime.Value = new System.DateTime(2020, 4, 26, 15, 57, 15, 0);
            // 
            // dateTimeEmploymentHallByDate_
            // 
            this.dateTimeEmploymentHallByDate_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEmploymentHallByDate_.Location = new System.Drawing.Point(179, 348);
            this.dateTimeEmploymentHallByDate_.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEmploymentHallByDate_.Name = "dateTimeEmploymentHallByDate_";
            this.dateTimeEmploymentHallByDate_.Size = new System.Drawing.Size(85, 20);
            this.dateTimeEmploymentHallByDate_.TabIndex = 33;
            // 
            // textBoxAddLessonIdClient
            // 
            this.textBoxAddLessonIdClient.Location = new System.Drawing.Point(179, 409);
            this.textBoxAddLessonIdClient.Name = "textBoxAddLessonIdClient";
            this.textBoxAddLessonIdClient.Size = new System.Drawing.Size(60, 20);
            this.textBoxAddLessonIdClient.TabIndex = 34;
            // 
            // textBoxAddLessonIdHall
            // 
            this.textBoxAddLessonIdHall.Location = new System.Drawing.Point(248, 409);
            this.textBoxAddLessonIdHall.Name = "textBoxAddLessonIdHall";
            this.textBoxAddLessonIdHall.Size = new System.Drawing.Size(81, 20);
            this.textBoxAddLessonIdHall.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Id клиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Id зала";
            // 
            // dateTimeAddLessonDate
            // 
            this.dateTimeAddLessonDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAddLessonDate.Location = new System.Drawing.Point(335, 409);
            this.dateTimeAddLessonDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeAddLessonDate.Name = "dateTimeAddLessonDate";
            this.dateTimeAddLessonDate.Size = new System.Drawing.Size(85, 20);
            this.dateTimeAddLessonDate.TabIndex = 38;
            // 
            // dateTimeAddLessonTime
            // 
            this.dateTimeAddLessonTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeAddLessonTime.Location = new System.Drawing.Point(426, 409);
            this.dateTimeAddLessonTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeAddLessonTime.Name = "dateTimeAddLessonTime";
            this.dateTimeAddLessonTime.Size = new System.Drawing.Size(85, 20);
            this.dateTimeAddLessonTime.TabIndex = 39;
            this.dateTimeAddLessonTime.Value = new System.DateTime(2020, 4, 26, 15, 57, 15, 0);
            // 
            // LessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 479);
            this.Controls.Add(this.dateTimeAddLessonTime);
            this.Controls.Add(this.dateTimeAddLessonDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddLessonIdHall);
            this.Controls.Add(this.textBoxAddLessonIdClient);
            this.Controls.Add(this.dateTimeEmploymentHallByDate_);
            this.Controls.Add(this.dateTimeEmploymentHallByDateTime);
            this.Controls.Add(this.dateTimeEmploymentHallByDate);
            this.Controls.Add(this.dateTimeEmploymentAllHallByDateTime);
            this.Controls.Add(this.dateTimeEmploymentAllHallByDate_);
            this.Controls.Add(this.dateTimeEmploymentAllHallByDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLessonByHallName);
            this.Controls.Add(this.labelDeleteSubNum);
            this.Controls.Add(this.TextBoxLessonBySubNumClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLessonByPhoneCoach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdLessons);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.btnEmploymentHallByDateTime);
            this.Controls.Add(this.btnEmploymentHallByDate);
            this.Controls.Add(this.btnEmploymentAllHallByDateTime);
            this.Controls.Add(this.btnEmploymentAllHallByDate);
            this.Controls.Add(this.btnGetLessonById);
            this.Controls.Add(this.btnGetAllLessonsByHallName);
            this.Controls.Add(this.btnGetAllLessonSubNumClient);
            this.Controls.Add(this.btnAlllessonByPhoneCoach);
            this.Controls.Add(this.btnGetAllLessons);
            this.Name = "LessonsForm";
            this.Text = "LessonsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllLessons;
        private System.Windows.Forms.Button btnAlllessonByPhoneCoach;
        private System.Windows.Forms.Button btnGetAllLessonSubNumClient;
        private System.Windows.Forms.Button btnGetAllLessonsByHallName;
        private System.Windows.Forms.Button btnGetLessonById;
        private System.Windows.Forms.Button btnEmploymentAllHallByDate;
        private System.Windows.Forms.Button btnEmploymentAllHallByDateTime;
        private System.Windows.Forms.Button btnEmploymentHallByDate;
        private System.Windows.Forms.Button btnEmploymentHallByDateTime;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.TextBox textBoxIdLessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLessonByPhoneCoach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLessonBySubNumClient;
        private System.Windows.Forms.Label labelDeleteSubNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLessonByHallName;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentAllHallByDate;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentAllHallByDate_;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentAllHallByDateTime;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentHallByDate;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentHallByDateTime;
        private System.Windows.Forms.DateTimePicker dateTimeEmploymentHallByDate_;
        private System.Windows.Forms.TextBox textBoxAddLessonIdClient;
        private System.Windows.Forms.TextBox textBoxAddLessonIdHall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeAddLessonDate;
        private System.Windows.Forms.DateTimePicker dateTimeAddLessonTime;
    }
}