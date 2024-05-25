namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class RegistrationForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_SurName = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Parol = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SurName = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Parol = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(127, 69);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 16);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Ім\'я";
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Location = new System.Drawing.Point(130, 128);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(69, 16);
            this.label_SurName.TabIndex = 2;
            this.label_SurName.Text = "Прізвище";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(139, 184);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(67, 16);
            this.label_Phone.TabIndex = 3;
            this.label_Phone.Text = "Телефон";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(151, 245);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(41, 16);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "Логін";
            // 
            // label_Parol
            // 
            this.label_Parol.AutoSize = true;
            this.label_Parol.Location = new System.Drawing.Point(154, 289);
            this.label_Parol.Name = "label_Parol";
            this.label_Parol.Size = new System.Drawing.Size(56, 16);
            this.label_Parol.TabIndex = 5;
            this.label_Parol.Text = "Пароль";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(133, 89);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.Location = new System.Drawing.Point(130, 147);
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(100, 22);
            this.textBox_SurName.TabIndex = 7;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(130, 204);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 22);
            this.textBox_Phone.TabIndex = 8;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(130, 265);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 22);
            this.textBox_Login.TabIndex = 9;
            // 
            // textBox_Parol
            // 
            this.textBox_Parol.Location = new System.Drawing.Point(130, 308);
            this.textBox_Parol.Name = "textBox_Parol";
            this.textBox_Parol.Size = new System.Drawing.Size(100, 22);
            this.textBox_Parol.TabIndex = 10;
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(130, 356);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(75, 23);
            this.button_Enter.TabIndex = 11;
            this.button_Enter.Text = "Увійти";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(652, 80);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 12;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox_Parol);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_SurName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Parol);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_SurName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "Оренда авто. Окно реєстрації";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Parol;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SurName;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Parol;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button button_Back;
    }
}