namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class ReportForm
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
            this.button_Cars = new System.Windows.Forms.Button();
            this.button_Users = new System.Windows.Forms.Button();
            this.button_Orders = new System.Windows.Forms.Button();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчёты:";
            // 
            // button_Cars
            // 
            this.button_Cars.Location = new System.Drawing.Point(52, 69);
            this.button_Cars.Name = "button_Cars";
            this.button_Cars.Size = new System.Drawing.Size(95, 23);
            this.button_Cars.TabIndex = 1;
            this.button_Cars.Text = "Автомобілі";
            this.button_Cars.UseVisualStyleBackColor = true;
            this.button_Cars.Click += new System.EventHandler(this.button_Cars_Click);
            // 
            // button_Users
            // 
            this.button_Users.Location = new System.Drawing.Point(189, 68);
            this.button_Users.Name = "button_Users";
            this.button_Users.Size = new System.Drawing.Size(100, 23);
            this.button_Users.TabIndex = 2;
            this.button_Users.Text = "Користувачі";
            this.button_Users.UseVisualStyleBackColor = true;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // button_Orders
            // 
            this.button_Orders.Location = new System.Drawing.Point(318, 68);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Size = new System.Drawing.Size(102, 23);
            this.button_Orders.TabIndex = 3;
            this.button_Orders.Text = "Замовлення";
            this.button_Orders.UseVisualStyleBackColor = true;
            this.button_Orders.Click += new System.EventHandler(this.button_Orders_Click);
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(689, 69);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 4;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.button_Orders);
            this.Controls.Add(this.button_Users);
            this.Controls.Add(this.button_Cars);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cars;
        private System.Windows.Forms.Button button_Users;
        private System.Windows.Forms.Button button_Orders;
        private System.Windows.Forms.Button button_ToMain;
    }
}