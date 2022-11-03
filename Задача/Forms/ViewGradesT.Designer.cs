namespace WindowsFormsApp1
{
    partial class ViewGradesT
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
            this.Back = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.FN = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 65);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(166, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(216, 65);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(166, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(216, 29);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(166, 20);
            this.FN.TabIndex = 2;
            // 
            // Subject
            // 
            this.Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(12, 28);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(166, 21);
            this.Subject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject";
            // 
            // ViewGradesT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 95);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Back);
            this.Name = "ViewGradesT";
            this.Text = "ViewGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}