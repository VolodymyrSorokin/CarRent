namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class IssueCarForm
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
            this.dataGridView_Issue = new System.Windows.Forms.DataGridView();
            this.Column_id_Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_booking_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_booking_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Issued = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Issue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_ToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Issue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Issue
            // 
            this.dataGridView_Issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Issue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_Car,
            this.Column_id_User,
            this.Column_booking_start_date,
            this.Column_booking_end_date,
            this.Column_Issued,
            this.Column_Issue,
            this.Column_Return});
            this.dataGridView_Issue.Location = new System.Drawing.Point(0, 83);
            this.dataGridView_Issue.Name = "dataGridView_Issue";
            this.dataGridView_Issue.RowHeadersWidth = 51;
            this.dataGridView_Issue.RowTemplate.Height = 24;
            this.dataGridView_Issue.Size = new System.Drawing.Size(808, 366);
            this.dataGridView_Issue.TabIndex = 0;
            this.dataGridView_Issue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Issue_CellContentClick);
            // 
            // Column_id_Car
            // 
            this.Column_id_Car.DataPropertyName = "id_Car";
            this.Column_id_Car.HeaderText = "id_Авто";
            this.Column_id_Car.MinimumWidth = 6;
            this.Column_id_Car.Name = "Column_id_Car";
            this.Column_id_Car.Width = 125;
            // 
            // Column_id_User
            // 
            this.Column_id_User.DataPropertyName = "id_User";
            this.Column_id_User.HeaderText = "id_Користувача";
            this.Column_id_User.MinimumWidth = 6;
            this.Column_id_User.Name = "Column_id_User";
            this.Column_id_User.Width = 125;
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
            // Column_Issued
            // 
            this.Column_Issued.DataPropertyName = "issued";
            this.Column_Issued.HeaderText = "Видано";
            this.Column_Issued.MinimumWidth = 6;
            this.Column_Issued.Name = "Column_Issued";
            this.Column_Issued.Width = 125;
            // 
            // Column_Issue
            // 
            this.Column_Issue.HeaderText = "Видати";
            this.Column_Issue.MinimumWidth = 6;
            this.Column_Issue.Name = "Column_Issue";
            this.Column_Issue.Text = "Видати";
            this.Column_Issue.UseColumnTextForButtonValue = true;
            this.Column_Issue.Width = 125;
            // 
            // Column_Return
            // 
            this.Column_Return.HeaderText = "Повернуто";
            this.Column_Return.MinimumWidth = 6;
            this.Column_Return.Name = "Column_Return";
            this.Column_Return.Text = "Повернуто";
            this.Column_Return.UseColumnTextForButtonValue = true;
            this.Column_Return.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Видати";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Видати";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Повернуто";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Повернуто";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 125;
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(702, 24);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 1;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // IssueCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.dataGridView_Issue);
            this.Name = "IssueCarForm";
            this.Text = "IssueCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Issue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Issue;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_booking_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_booking_end_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Issued;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Issue;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Return;
    }
}