namespace Employes
{
    partial class Form1
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
            this.LBL_FullName = new System.Windows.Forms.Label();
            this.LBL_Birthday = new System.Windows.Forms.Label();
            this.LBL_SerialNumber = new System.Windows.Forms.Label();
            this.LBL_TypeDoc = new System.Windows.Forms.Label();
            this.LBL_DateIssue = new System.Windows.Forms.Label();
            this.LBL_AutorIssue = new System.Windows.Forms.Label();
            this.LBL_PhoneNumber = new System.Windows.Forms.Label();
            this.LBL_TypePhone = new System.Windows.Forms.Label();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.textBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.textBox_TypeDoc = new System.Windows.Forms.TextBox();
            this.textBoxAutorIssue = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_TypePhone = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateIssue = new System.Windows.Forms.DateTimePicker();
            this.button_Find = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_FullName
            // 
            this.LBL_FullName.AutoSize = true;
            this.LBL_FullName.Location = new System.Drawing.Point(28, 36);
            this.LBL_FullName.Name = "LBL_FullName";
            this.LBL_FullName.Size = new System.Drawing.Size(34, 13);
            this.LBL_FullName.TabIndex = 0;
            this.LBL_FullName.Text = "ФИО";
            // 
            // LBL_Birthday
            // 
            this.LBL_Birthday.AutoSize = true;
            this.LBL_Birthday.Location = new System.Drawing.Point(28, 59);
            this.LBL_Birthday.Name = "LBL_Birthday";
            this.LBL_Birthday.Size = new System.Drawing.Size(86, 13);
            this.LBL_Birthday.TabIndex = 1;
            this.LBL_Birthday.Text = "Дата рождения";
            // 
            // LBL_SerialNumber
            // 
            this.LBL_SerialNumber.AutoSize = true;
            this.LBL_SerialNumber.Location = new System.Drawing.Point(28, 90);
            this.LBL_SerialNumber.Name = "LBL_SerialNumber";
            this.LBL_SerialNumber.Size = new System.Drawing.Size(75, 13);
            this.LBL_SerialNumber.TabIndex = 2;
            this.LBL_SerialNumber.Text = "Серия/номер";
            // 
            // LBL_TypeDoc
            // 
            this.LBL_TypeDoc.AutoSize = true;
            this.LBL_TypeDoc.Location = new System.Drawing.Point(28, 118);
            this.LBL_TypeDoc.Name = "LBL_TypeDoc";
            this.LBL_TypeDoc.Size = new System.Drawing.Size(83, 13);
            this.LBL_TypeDoc.TabIndex = 3;
            this.LBL_TypeDoc.Text = "Тип документа";
            // 
            // LBL_DateIssue
            // 
            this.LBL_DateIssue.AutoSize = true;
            this.LBL_DateIssue.Location = new System.Drawing.Point(28, 148);
            this.LBL_DateIssue.Name = "LBL_DateIssue";
            this.LBL_DateIssue.Size = new System.Drawing.Size(73, 13);
            this.LBL_DateIssue.TabIndex = 4;
            this.LBL_DateIssue.Text = "Дата выдачи";
            // 
            // LBL_AutorIssue
            // 
            this.LBL_AutorIssue.AutoSize = true;
            this.LBL_AutorIssue.Location = new System.Drawing.Point(28, 182);
            this.LBL_AutorIssue.Name = "LBL_AutorIssue";
            this.LBL_AutorIssue.Size = new System.Drawing.Size(63, 13);
            this.LBL_AutorIssue.TabIndex = 5;
            this.LBL_AutorIssue.Text = "Кем выдан";
            // 
            // LBL_PhoneNumber
            // 
            this.LBL_PhoneNumber.AutoSize = true;
            this.LBL_PhoneNumber.Location = new System.Drawing.Point(28, 210);
            this.LBL_PhoneNumber.Name = "LBL_PhoneNumber";
            this.LBL_PhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.LBL_PhoneNumber.TabIndex = 6;
            this.LBL_PhoneNumber.Text = "Телефон";
            // 
            // LBL_TypePhone
            // 
            this.LBL_TypePhone.AutoSize = true;
            this.LBL_TypePhone.Location = new System.Drawing.Point(28, 235);
            this.LBL_TypePhone.Name = "LBL_TypePhone";
            this.LBL_TypePhone.Size = new System.Drawing.Size(78, 13);
            this.LBL_TypePhone.TabIndex = 7;
            this.LBL_TypePhone.Text = "Тип телефона";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(409, 39);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Female.TabIndex = 8;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пол: М        Ж";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(441, 39);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Male.TabIndex = 10;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(147, 32);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(205, 20);
            this.textBox_FullName.TabIndex = 11;
            // 
            // textBox_SerialNumber
            // 
            this.textBox_SerialNumber.Location = new System.Drawing.Point(147, 83);
            this.textBox_SerialNumber.Name = "textBox_SerialNumber";
            this.textBox_SerialNumber.Size = new System.Drawing.Size(172, 20);
            this.textBox_SerialNumber.TabIndex = 13;
            // 
            // textBox_TypeDoc
            // 
            this.textBox_TypeDoc.Location = new System.Drawing.Point(147, 111);
            this.textBox_TypeDoc.Name = "textBox_TypeDoc";
            this.textBox_TypeDoc.Size = new System.Drawing.Size(172, 20);
            this.textBox_TypeDoc.TabIndex = 14;
            // 
            // textBoxAutorIssue
            // 
            this.textBoxAutorIssue.Location = new System.Drawing.Point(147, 175);
            this.textBoxAutorIssue.Name = "textBoxAutorIssue";
            this.textBoxAutorIssue.Size = new System.Drawing.Size(172, 20);
            this.textBoxAutorIssue.TabIndex = 16;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(147, 203);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.textBox_PhoneNumber.TabIndex = 17;
            // 
            // textBox_TypePhone
            // 
            this.textBox_TypePhone.Location = new System.Drawing.Point(147, 228);
            this.textBox_TypePhone.Name = "textBox_TypePhone";
            this.textBox_TypePhone.Size = new System.Drawing.Size(172, 20);
            this.textBox_TypePhone.TabIndex = 18;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(147, 57);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Birthday.TabIndex = 19;
            // 
            // dateTimePicker_DateIssue
            // 
            this.dateTimePicker_DateIssue.Location = new System.Drawing.Point(147, 142);
            this.dateTimePicker_DateIssue.Name = "dateTimePicker_DateIssue";
            this.dateTimePicker_DateIssue.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DateIssue.TabIndex = 20;
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(621, 39);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Find.TabIndex = 21;
            this.button_Find.Text = "Поиск";
            this.button_Find.UseVisualStyleBackColor = true;
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(28, 329);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(99, 23);
            this.button_Change.TabIndex = 22;
            this.button_Change.Text = "Редактировать";
            this.button_Change.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(161, 329);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(99, 23);
            this.button_Delete.TabIndex = 23;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(324, 329);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(99, 23);
            this.button_Add.TabIndex = 24;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.dateTimePicker_DateIssue);
            this.Controls.Add(this.dateTimePicker_Birthday);
            this.Controls.Add(this.textBox_TypePhone);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBoxAutorIssue);
            this.Controls.Add(this.textBox_TypeDoc);
            this.Controls.Add(this.textBox_SerialNumber);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.LBL_TypePhone);
            this.Controls.Add(this.LBL_PhoneNumber);
            this.Controls.Add(this.LBL_AutorIssue);
            this.Controls.Add(this.LBL_DateIssue);
            this.Controls.Add(this.LBL_TypeDoc);
            this.Controls.Add(this.LBL_SerialNumber);
            this.Controls.Add(this.LBL_Birthday);
            this.Controls.Add(this.LBL_FullName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_FullName;
        private System.Windows.Forms.Label LBL_Birthday;
        private System.Windows.Forms.Label LBL_SerialNumber;
        private System.Windows.Forms.Label LBL_TypeDoc;
        private System.Windows.Forms.Label LBL_DateIssue;
        private System.Windows.Forms.Label LBL_AutorIssue;
        private System.Windows.Forms.Label LBL_PhoneNumber;
        private System.Windows.Forms.Label LBL_TypePhone;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.TextBox textBox_SerialNumber;
        private System.Windows.Forms.TextBox textBox_TypeDoc;
        private System.Windows.Forms.TextBox textBoxAutorIssue;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_TypePhone;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateIssue;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
    }
}

