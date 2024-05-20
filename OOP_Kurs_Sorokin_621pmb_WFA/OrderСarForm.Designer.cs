namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class OrderСarForm
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
            this.dateTimePicker_BookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.button_AvailableCars = new System.Windows.Forms.Button();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.Column_idCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Booking = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_BookingStartDate
            // 
            this.dateTimePicker_BookingStartDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BookingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BookingStartDate.Location = new System.Drawing.Point(12, 35);
            this.dateTimePicker_BookingStartDate.Name = "dateTimePicker_BookingStartDate";
            this.dateTimePicker_BookingStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_BookingStartDate.TabIndex = 0;
            // 
            // dateTimePicker_BookingEndDate
            // 
            this.dateTimePicker_BookingEndDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BookingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BookingEndDate.Location = new System.Drawing.Point(236, 35);
            this.dateTimePicker_BookingEndDate.Name = "dateTimePicker_BookingEndDate";
            this.dateTimePicker_BookingEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_BookingEndDate.TabIndex = 1;
            // 
            // button_AvailableCars
            // 
            this.button_AvailableCars.Location = new System.Drawing.Point(485, 33);
            this.button_AvailableCars.Name = "button_AvailableCars";
            this.button_AvailableCars.Size = new System.Drawing.Size(111, 23);
            this.button_AvailableCars.TabIndex = 2;
            this.button_AvailableCars.Text = "Доступні авто";
            this.button_AvailableCars.UseVisualStyleBackColor = true;
            this.button_AvailableCars.Click += new System.EventHandler(this.button_AvailableCars_Click);
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(627, 33);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(101, 23);
            this.button_ToMain.TabIndex = 3;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_idCar,
            this.Manufacturer,
            this.Model,
            this.Year,
            this.BodyType,
            this.Price,
            this.Column_Booking});
            this.dataGridView_Order.Location = new System.Drawing.Point(2, 97);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(797, 341);
            this.dataGridView_Order.TabIndex = 4;
            this.dataGridView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Order_CellContentClick);
            // 
            // Column_idCar
            // 
            this.Column_idCar.DataPropertyName = "id_Car";
            this.Column_idCar.HeaderText = "ID_Авто";
            this.Column_idCar.MinimumWidth = 6;
            this.Column_idCar.Name = "Column_idCar";
            this.Column_idCar.Width = 125;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "manufacturer";
            this.Manufacturer.HeaderText = "Виробник";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "model";
            this.Model.HeaderText = "Модел";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "year";
            this.Year.HeaderText = "Рік";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // BodyType
            // 
            this.BodyType.DataPropertyName = "bodyType";
            this.BodyType.HeaderText = "ТипКорпусу";
            this.BodyType.MinimumWidth = 6;
            this.BodyType.Name = "BodyType";
            this.BodyType.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Ціна";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Замовити";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "Замовити";
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // Column_Booking
            // 
            this.Column_Booking.HeaderText = "Замовити";
            this.Column_Booking.MinimumWidth = 6;
            this.Column_Booking.Name = "Column_Booking";
            this.Column_Booking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Booking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Booking.Text = "Замовити";
            this.Column_Booking.Width = 125;
            // 
            // OrderСarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Order);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.button_AvailableCars);
            this.Controls.Add(this.dateTimePicker_BookingEndDate);
            this.Controls.Add(this.dateTimePicker_BookingStartDate);
            this.Name = "OrderСarForm";
            this.Text = "Form_Order_Сar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_BookingStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookingEndDate;
        private System.Windows.Forms.Button button_AvailableCars;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_idCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Booking;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}