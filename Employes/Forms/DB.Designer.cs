namespace Employes.Forms
{
    partial class DB
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DataSourse = new System.Windows.Forms.TextBox();
            this.textBox_InitialCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSourse";
            // 
            // textBox_DataSourse
            // 
            this.textBox_DataSourse.Location = new System.Drawing.Point(113, 53);
            this.textBox_DataSourse.Name = "textBox_DataSourse";
            this.textBox_DataSourse.Size = new System.Drawing.Size(100, 20);
            this.textBox_DataSourse.TabIndex = 1;
            // 
            // textBox_InitialCatalog
            // 
            this.textBox_InitialCatalog.Location = new System.Drawing.Point(113, 79);
            this.textBox_InitialCatalog.Name = "textBox_InitialCatalog";
            this.textBox_InitialCatalog.Size = new System.Drawing.Size(100, 20);
            this.textBox_InitialCatalog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Catalog";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_UserId
            // 
            this.textBox_UserId.Location = new System.Drawing.Point(113, 114);
            this.textBox_UserId.Name = "textBox_UserId";
            this.textBox_UserId.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserId";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(113, 140);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Подключить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_UserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_InitialCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DataSourse);
            this.Controls.Add(this.label1);
            this.Name = "DB";
            this.Text = "DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DataSourse;
        private System.Windows.Forms.TextBox textBox_InitialCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}