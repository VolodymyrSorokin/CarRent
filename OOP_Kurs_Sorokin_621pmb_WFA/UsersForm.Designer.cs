namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class UsersForm
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
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.Column_id_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Користувачі:";
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_User,
            this.Column_LastName,
            this.Column_FirstName,
            this.Column_Phone});
            this.dataGridView_Users.Location = new System.Drawing.Point(12, 88);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.RowHeadersWidth = 51;
            this.dataGridView_Users.RowTemplate.Height = 24;
            this.dataGridView_Users.Size = new System.Drawing.Size(776, 350);
            this.dataGridView_Users.TabIndex = 1;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(213, 13);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(49, 16);
            this.label_Search.TabIndex = 2;
            this.label_Search.Text = "Пошук";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(216, 42);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(100, 22);
            this.textBox_Search.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(334, 40);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Пошук";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(700, 40);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 5;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // Column_id_User
            // 
            this.Column_id_User.DataPropertyName = "Id_User";
            this.Column_id_User.HeaderText = "id Користувача";
            this.Column_id_User.MinimumWidth = 6;
            this.Column_id_User.Name = "Column_id_User";
            this.Column_id_User.Width = 125;
            // 
            // Column_LastName
            // 
            this.Column_LastName.DataPropertyName = "LastName";
            this.Column_LastName.HeaderText = "Прізвище";
            this.Column_LastName.MinimumWidth = 6;
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.Width = 125;
            // 
            // Column_FirstName
            // 
            this.Column_FirstName.DataPropertyName = "FirstName";
            this.Column_FirstName.HeaderText = "Ім\'я";
            this.Column_FirstName.MinimumWidth = 6;
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.Width = 125;
            // 
            // Column_Phone
            // 
            this.Column_Phone.DataPropertyName = "Phone";
            this.Column_Phone.HeaderText = "Телефон";
            this.Column_Phone.MinimumWidth = 6;
            this.Column_Phone.Name = "Column_Phone";
            this.Column_Phone.Width = 125;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.label1);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
    }
}