namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class AuthorizationForm
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
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Parol = new System.Windows.Forms.Label();
            this.button_Enter = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Parol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизація";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(114, 101);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(41, 16);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Логін";
            // 
            // label_Parol
            // 
            this.label_Parol.AutoSize = true;
            this.label_Parol.Location = new System.Drawing.Point(117, 203);
            this.label_Parol.Name = "label_Parol";
            this.label_Parol.Size = new System.Drawing.Size(56, 16);
            this.label_Parol.TabIndex = 2;
            this.label_Parol.Text = "Пароль";
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(79, 275);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(75, 23);
            this.button_Enter.TabIndex = 3;
            this.button_Enter.Text = "Увійти";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(114, 120);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 22);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_Parol
            // 
            this.textBox_Parol.Location = new System.Drawing.Point(120, 223);
            this.textBox_Parol.Name = "textBox_Parol";
            this.textBox_Parol.Size = new System.Drawing.Size(100, 22);
            this.textBox_Parol.TabIndex = 5;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Parol);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label_Parol);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.Text = "Оренда авто. Вікно авторизації.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Parol;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Parol;
    }
}