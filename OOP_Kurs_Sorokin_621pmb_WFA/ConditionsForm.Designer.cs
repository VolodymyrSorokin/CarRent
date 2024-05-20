namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    partial class ConditionsForm
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
            this.textBox_Conditions = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_ToMain = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Умови:";
            // 
            // textBox_Conditions
            // 
            this.textBox_Conditions.Location = new System.Drawing.Point(13, 68);
            this.textBox_Conditions.Multiline = true;
            this.textBox_Conditions.Name = "textBox_Conditions";
            this.textBox_Conditions.ReadOnly = true;
            this.textBox_Conditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Conditions.Size = new System.Drawing.Size(775, 370);
            this.textBox_Conditions.TabIndex = 1;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(454, 13);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(98, 23);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Редагувати";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click_1);
            // 
            // button_ToMain
            // 
            this.button_ToMain.Location = new System.Drawing.Point(713, 13);
            this.button_ToMain.Name = "button_ToMain";
            this.button_ToMain.Size = new System.Drawing.Size(75, 23);
            this.button_ToMain.TabIndex = 3;
            this.button_ToMain.Text = "Головна";
            this.button_ToMain.UseVisualStyleBackColor = true;
            this.button_ToMain.Click += new System.EventHandler(this.button_ToMain_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(590, 13);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(81, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Зберегти";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click_1);
            // 
            // ConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_ToMain);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.textBox_Conditions);
            this.Controls.Add(this.label1);
            this.Name = "ConditionsForm";
            this.Text = "ConditionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Conditions;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_ToMain;
        private System.Windows.Forms.Button button_Save;
    }
}