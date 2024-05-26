namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class OrdersReportForm
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
            this.dataGridView_OrdersReport = new System.Windows.Forms.DataGridView();
            this.Column_id_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id_Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_booking_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_booking_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrdersReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Замовлення:";
            // 
            // dataGridView_OrdersReport
            // 
            this.dataGridView_OrdersReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrdersReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_User,
            this.Column_id_Car,
            this.Column_booking_start_date,
            this.Column_booking_end_date});
            this.dataGridView_OrdersReport.Location = new System.Drawing.Point(12, 72);
            this.dataGridView_OrdersReport.Name = "dataGridView_OrdersReport";
            this.dataGridView_OrdersReport.RowHeadersWidth = 51;
            this.dataGridView_OrdersReport.RowTemplate.Height = 24;
            this.dataGridView_OrdersReport.Size = new System.Drawing.Size(776, 366);
            this.dataGridView_OrdersReport.TabIndex = 1;
            // 
            // Column_id_User
            // 
            this.Column_id_User.DataPropertyName = "id_User";
            this.Column_id_User.HeaderText = "id Користувача";
            this.Column_id_User.MinimumWidth = 6;
            this.Column_id_User.Name = "Column_id_User";
            this.Column_id_User.Width = 125;
            // 
            // Column_id_Car
            // 
            this.Column_id_Car.DataPropertyName = "id_Car";
            this.Column_id_Car.HeaderText = "id Авто";
            this.Column_id_Car.MinimumWidth = 6;
            this.Column_id_Car.Name = "Column_id_Car";
            this.Column_id_Car.Width = 125;
            // 
            // Column_booking_start_date
            // 
            this.Column_booking_start_date.DataPropertyName = "booking_start_date";
            this.Column_booking_start_date.HeaderText = "Початок бронювання";
            this.Column_booking_start_date.MinimumWidth = 6;
            this.Column_booking_start_date.Name = "Column_booking_start_date";
            this.Column_booking_start_date.Width = 125;
            // 
            // Column_booking_end_date
            // 
            this.Column_booking_end_date.DataPropertyName = "booking_end_date";
            this.Column_booking_end_date.HeaderText = "Кінець бронювання";
            this.Column_booking_end_date.MinimumWidth = 6;
            this.Column_booking_end_date.Name = "Column_booking_end_date";
            this.Column_booking_end_date.Width = 125;
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(696, 27);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 2;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(194, 27);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Date.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(415, 26);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Пошук";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата бронювання";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(595, 26);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 6;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // OrdersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.dataGridView_OrdersReport);
            this.Controls.Add(this.label1);
            this.Name = "OrdersReportForm";
            this.Text = "OrdersReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrdersReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_OrdersReport;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_booking_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_booking_end_date;
        private System.Windows.Forms.Button button_Back;
    }
}