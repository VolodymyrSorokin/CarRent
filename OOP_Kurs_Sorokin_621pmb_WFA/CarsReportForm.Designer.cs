namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class CarsReportForm
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
            this.dataGridView_CarsReport = new System.Windows.Forms.DataGridView();
            this.Column_id_Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BodyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автомобілі:";
            // 
            // dataGridView_CarsReport
            // 
            this.dataGridView_CarsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CarsReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_Car,
            this.Column_Manufacturer,
            this.Column_Model,
            this.Column_Year,
            this.Column_BodyType,
            this.Column_Price});
            this.dataGridView_CarsReport.Location = new System.Drawing.Point(5, 52);
            this.dataGridView_CarsReport.Name = "dataGridView_CarsReport";
            this.dataGridView_CarsReport.RowHeadersWidth = 51;
            this.dataGridView_CarsReport.RowTemplate.Height = 24;
            this.dataGridView_CarsReport.Size = new System.Drawing.Size(791, 386);
            this.dataGridView_CarsReport.TabIndex = 1;
            // 
            // Column_id_Car
            // 
            this.Column_id_Car.DataPropertyName = "id_Car";
            this.Column_id_Car.HeaderText = "id Авто";
            this.Column_id_Car.MinimumWidth = 6;
            this.Column_id_Car.Name = "Column_id_Car";
            this.Column_id_Car.Width = 125;
            // 
            // Column_Manufacturer
            // 
            this.Column_Manufacturer.DataPropertyName = "Manufacturer";
            this.Column_Manufacturer.HeaderText = "Виробник";
            this.Column_Manufacturer.MinimumWidth = 6;
            this.Column_Manufacturer.Name = "Column_Manufacturer";
            this.Column_Manufacturer.Width = 125;
            // 
            // Column_Model
            // 
            this.Column_Model.DataPropertyName = "Model";
            this.Column_Model.HeaderText = "Модель";
            this.Column_Model.MinimumWidth = 6;
            this.Column_Model.Name = "Column_Model";
            this.Column_Model.Width = 125;
            // 
            // Column_Year
            // 
            this.Column_Year.DataPropertyName = "Year";
            this.Column_Year.HeaderText = "Рік";
            this.Column_Year.MinimumWidth = 6;
            this.Column_Year.Name = "Column_Year";
            this.Column_Year.Width = 125;
            // 
            // Column_BodyType
            // 
            this.Column_BodyType.DataPropertyName = "BodyType";
            this.Column_BodyType.HeaderText = "Тип корпусу";
            this.Column_BodyType.MinimumWidth = 6;
            this.Column_BodyType.Name = "Column_BodyType";
            this.Column_BodyType.Width = 125;
            // 
            // Column_Price
            // 
            this.Column_Price.DataPropertyName = "Price";
            this.Column_Price.HeaderText = "Ціна";
            this.Column_Price.MinimumWidth = 6;
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.Width = 125;
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(666, 22);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 2;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // CarsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.dataGridView_CarsReport);
            this.Controls.Add(this.label1);
            this.Name = "CarsReportForm";
            this.Text = "CarsReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarsReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_CarsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.Button button_ToMain;
    }
}