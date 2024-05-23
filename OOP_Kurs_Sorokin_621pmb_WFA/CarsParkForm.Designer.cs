namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class CarsParkForm
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
            this.label_Main = new System.Windows.Forms.Label();
            this.dataGridView_CarsPark = new System.Windows.Forms.DataGridView();
            this.Column_manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_bodyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_isAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_Conditions = new System.Windows.Forms.Button();
            this.button_Reviews = new System.Windows.Forms.Button();
            this.button_Contacts = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Out = new System.Windows.Forms.Button();
            this.button_Issue = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarsPark)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Main
            // 
            this.label_Main.AutoSize = true;
            this.label_Main.Location = new System.Drawing.Point(249, 9);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(126, 16);
            this.label_Main.TabIndex = 0;
            this.label_Main.Text = "Головна сторинка";
            // 
            // dataGridView_CarsPark
            // 
            this.dataGridView_CarsPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CarsPark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_manufacturer,
            this.Column_model,
            this.Column_year,
            this.Column_bodyType,
            this.Column_price,
            this.Column_isAvailable});
            this.dataGridView_CarsPark.Location = new System.Drawing.Point(2, 89);
            this.dataGridView_CarsPark.Name = "dataGridView_CarsPark";
            this.dataGridView_CarsPark.RowHeadersWidth = 51;
            this.dataGridView_CarsPark.RowTemplate.Height = 24;
            this.dataGridView_CarsPark.Size = new System.Drawing.Size(793, 349);
            this.dataGridView_CarsPark.TabIndex = 1;
            // 
            // Column_manufacturer
            // 
            this.Column_manufacturer.DataPropertyName = "manufacturer";
            this.Column_manufacturer.HeaderText = "Виробник";
            this.Column_manufacturer.MinimumWidth = 6;
            this.Column_manufacturer.Name = "Column_manufacturer";
            this.Column_manufacturer.Width = 125;
            // 
            // Column_model
            // 
            this.Column_model.DataPropertyName = "model";
            this.Column_model.HeaderText = "Модель";
            this.Column_model.MinimumWidth = 6;
            this.Column_model.Name = "Column_model";
            this.Column_model.Width = 125;
            // 
            // Column_year
            // 
            this.Column_year.DataPropertyName = "year";
            this.Column_year.HeaderText = "Рік";
            this.Column_year.MinimumWidth = 6;
            this.Column_year.Name = "Column_year";
            this.Column_year.Width = 125;
            // 
            // Column_bodyType
            // 
            this.Column_bodyType.DataPropertyName = "bodyType";
            this.Column_bodyType.HeaderText = "ТипКорпусу";
            this.Column_bodyType.MinimumWidth = 6;
            this.Column_bodyType.Name = "Column_bodyType";
            this.Column_bodyType.Width = 125;
            // 
            // Column_price
            // 
            this.Column_price.DataPropertyName = "price";
            this.Column_price.HeaderText = "Ціна";
            this.Column_price.MinimumWidth = 6;
            this.Column_price.Name = "Column_price";
            this.Column_price.Width = 125;
            // 
            // Column_isAvailable
            // 
            this.Column_isAvailable.DataPropertyName = "isAvailable";
            this.Column_isAvailable.HeaderText = "Наявність";
            this.Column_isAvailable.MinimumWidth = 6;
            this.Column_isAvailable.Name = "Column_isAvailable";
            this.Column_isAvailable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_isAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_isAvailable.Width = 125;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(416, 32);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Додати";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Order
            // 
            this.button_Order.Location = new System.Drawing.Point(15, 31);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(75, 23);
            this.button_Order.TabIndex = 7;
            this.button_Order.Text = "Замовити";
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_Conditions
            // 
            this.button_Conditions.Location = new System.Drawing.Point(116, 32);
            this.button_Conditions.Name = "button_Conditions";
            this.button_Conditions.Size = new System.Drawing.Size(75, 23);
            this.button_Conditions.TabIndex = 8;
            this.button_Conditions.Text = "Умови";
            this.button_Conditions.UseVisualStyleBackColor = true;
            this.button_Conditions.Click += new System.EventHandler(this.button_Conditions_Click);
            // 
            // button_Reviews
            // 
            this.button_Reviews.Location = new System.Drawing.Point(217, 32);
            this.button_Reviews.Name = "button_Reviews";
            this.button_Reviews.Size = new System.Drawing.Size(75, 23);
            this.button_Reviews.TabIndex = 9;
            this.button_Reviews.Text = "Відгуки";
            this.button_Reviews.UseVisualStyleBackColor = true;
            this.button_Reviews.Click += new System.EventHandler(this.button_Reviews_Click);
            // 
            // button_Contacts
            // 
            this.button_Contacts.Location = new System.Drawing.Point(314, 32);
            this.button_Contacts.Name = "button_Contacts";
            this.button_Contacts.Size = new System.Drawing.Size(85, 23);
            this.button_Contacts.TabIndex = 10;
            this.button_Contacts.Text = "Контакти";
            this.button_Contacts.UseVisualStyleBackColor = true;
            this.button_Contacts.Click += new System.EventHandler(this.button_Contacts_Click);
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(516, 31);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 23);
            this.button_Report.TabIndex = 11;
            this.button_Report.Text = "Звіт";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Location = new System.Drawing.Point(616, 31);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(75, 24);
            this.button_Logout.TabIndex = 12;
            this.button_Logout.Text = "LogOut";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Out
            // 
            this.button_Out.Location = new System.Drawing.Point(711, 31);
            this.button_Out.Name = "button_Out";
            this.button_Out.Size = new System.Drawing.Size(75, 23);
            this.button_Out.TabIndex = 13;
            this.button_Out.Text = "Вихід";
            this.button_Out.UseVisualStyleBackColor = true;
            this.button_Out.Click += new System.EventHandler(this.button_Out_Click);
            // 
            // button_Issue
            // 
            this.button_Issue.Location = new System.Drawing.Point(517, 60);
            this.button_Issue.Name = "button_Issue";
            this.button_Issue.Size = new System.Drawing.Size(75, 23);
            this.button_Issue.TabIndex = 14;
            this.button_Issue.Text = "Видача";
            this.button_Issue.UseVisualStyleBackColor = true;
            this.button_Issue.Click += new System.EventHandler(this.button_Issue_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(417, 60);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(122, 61);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Find.TabIndex = 16;
            this.button_Find.Text = "Шукати";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBox_Find
            // 
            this.textBox_Find.Location = new System.Drawing.Point(15, 61);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(100, 22);
            this.textBox_Find.TabIndex = 17;
            // 
            // CarsParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Find);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Issue);
            this.Controls.Add(this.button_Out);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_Contacts);
            this.Controls.Add(this.button_Reviews);
            this.Controls.Add(this.button_Conditions);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_CarsPark);
            this.Controls.Add(this.label_Main);
            this.Name = "CarsParkForm";
            this.Text = "Оренда авто. Автопарк.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarsPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Main;
        private System.Windows.Forms.DataGridView dataGridView_CarsPark;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_Conditions;
        private System.Windows.Forms.Button button_Reviews;
        private System.Windows.Forms.Button button_Contacts;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_bodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_isAvailable;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Out;
        private System.Windows.Forms.Button button_Issue;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBox_Find;
    }
}