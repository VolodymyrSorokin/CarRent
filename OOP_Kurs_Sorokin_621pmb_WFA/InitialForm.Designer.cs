namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class InitialForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Authorization = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_Guest = new System.Windows.Forms.Button();
            this.button_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для входу в систему \"Оренда авто\" натисніть одну з нижченаведених кнопок.";
            // 
            // button_Authorization
            // 
            this.button_Authorization.Location = new System.Drawing.Point(105, 85);
            this.button_Authorization.Name = "button_Authorization";
            this.button_Authorization.Size = new System.Drawing.Size(103, 23);
            this.button_Authorization.TabIndex = 6;
            this.button_Authorization.Text = "Авторізація";
            this.button_Authorization.UseVisualStyleBackColor = true;
            this.button_Authorization.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(244, 85);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(111, 23);
            this.button_Registration.TabIndex = 7;
            this.button_Registration.Text = "Реєстрація";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // button_Guest
            // 
            this.button_Guest.Location = new System.Drawing.Point(381, 85);
            this.button_Guest.Name = "button_Guest";
            this.button_Guest.Size = new System.Drawing.Size(136, 23);
            this.button_Guest.TabIndex = 8;
            this.button_Guest.Text = "Увійти як гість";
            this.button_Guest.UseVisualStyleBackColor = true;
            this.button_Guest.Click += new System.EventHandler(this.button_Guest_Click);
            // 
            // button_Out
            // 
            this.button_Out.Location = new System.Drawing.Point(665, 84);
            this.button_Out.Name = "button_Out";
            this.button_Out.Size = new System.Drawing.Size(75, 23);
            this.button_Out.TabIndex = 9;
            this.button_Out.Text = "Вихід";
            this.button_Out.UseVisualStyleBackColor = true;
            this.button_Out.Click += new System.EventHandler(this.button_Out_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Out);
            this.Controls.Add(this.button_Guest);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_Authorization);
            this.Controls.Add(this.label1);
            this.Name = "InitialForm";
            this.Text = "Оренда авто. Вікно входу до системи.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Authorization;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_Guest;
        private System.Windows.Forms.Button button_Out;
    }
}

