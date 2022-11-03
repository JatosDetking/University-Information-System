namespace WindowsFormsApp1
{
    partial class ViewZaverkiS
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
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(166, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Subject";
            // 
            // Subject
            // 
            this.Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(12, 29);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(166, 21);
            this.Subject.TabIndex = 12;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 96);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(166, 23);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ViewZaverkiS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 136);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Back);
            this.Name = "ViewZaverkiS";
            this.Text = "ViewZaverki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Button Back;
    }
}