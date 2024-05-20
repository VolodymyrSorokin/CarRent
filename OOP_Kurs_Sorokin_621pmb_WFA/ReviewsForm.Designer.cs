namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class ReviewsForm
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
            this.dataGridView_Reviews = new System.Windows.Forms.DataGridView();
            this.button_AddReview = new System.Windows.Forms.Button();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.label_Reviews = new System.Windows.Forms.Label();
            this.textBox_NewReview = new System.Windows.Forms.TextBox();
            this.Column_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Reviews
            // 
            this.dataGridView_Reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Username,
            this.Column_Date,
            this.Column_Content});
            this.dataGridView_Reviews.Location = new System.Drawing.Point(3, 95);
            this.dataGridView_Reviews.Name = "dataGridView_Reviews";
            this.dataGridView_Reviews.RowHeadersWidth = 51;
            this.dataGridView_Reviews.RowTemplate.Height = 24;
            this.dataGridView_Reviews.Size = new System.Drawing.Size(795, 351);
            this.dataGridView_Reviews.TabIndex = 0;
            // 
            // button_AddReview
            // 
            this.button_AddReview.Location = new System.Drawing.Point(701, 43);
            this.button_AddReview.Name = "button_AddReview";
            this.button_AddReview.Size = new System.Drawing.Size(75, 23);
            this.button_AddReview.TabIndex = 1;
            this.button_AddReview.Text = "Ввестти";
            this.button_AddReview.UseVisualStyleBackColor = true;
            this.button_AddReview.Click += new System.EventHandler(this.button_AddReview_Click);
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(701, 12);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 2;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // label_Reviews
            // 
            this.label_Reviews.AutoSize = true;
            this.label_Reviews.Location = new System.Drawing.Point(25, 12);
            this.label_Reviews.Name = "label_Reviews";
            this.label_Reviews.Size = new System.Drawing.Size(59, 16);
            this.label_Reviews.TabIndex = 3;
            this.label_Reviews.Text = "Відгуки:";
            // 
            // textBox_NewReview
            // 
            this.textBox_NewReview.Location = new System.Drawing.Point(3, 43);
            this.textBox_NewReview.Name = "textBox_NewReview";
            this.textBox_NewReview.Size = new System.Drawing.Size(692, 22);
            this.textBox_NewReview.TabIndex = 4;
            // 
            // Column_Username
            // 
            this.Column_Username.DataPropertyName = "Username";
            this.Column_Username.HeaderText = "Користувач";
            this.Column_Username.MinimumWidth = 6;
            this.Column_Username.Name = "Column_Username";
            this.Column_Username.Width = 125;
            // 
            // Column_Date
            // 
            this.Column_Date.DataPropertyName = "Date";
            this.Column_Date.HeaderText = "Дата";
            this.Column_Date.MinimumWidth = 6;
            this.Column_Date.Name = "Column_Date";
            this.Column_Date.Width = 125;
            // 
            // Column_Content
            // 
            this.Column_Content.DataPropertyName = "Content";
            this.Column_Content.HeaderText = "Відгук";
            this.Column_Content.MinimumWidth = 6;
            this.Column_Content.Name = "Column_Content";
            this.Column_Content.Width = 125;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_NewReview);
            this.Controls.Add(this.label_Reviews);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.button_AddReview);
            this.Controls.Add(this.dataGridView_Reviews);
            this.Name = "ReviewsForm";
            this.Text = "ReviewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Reviews;
        private System.Windows.Forms.Button button_AddReview;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.Label label_Reviews;
        private System.Windows.Forms.TextBox textBox_NewReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Content;
    }
}