namespace leetcode
{
    partial class LeetCodeMainForm
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
            this.GetMoviesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetMoviesButton
            // 
            this.GetMoviesButton.Location = new System.Drawing.Point(12, 12);
            this.GetMoviesButton.Name = "GetMoviesButton";
            this.GetMoviesButton.Size = new System.Drawing.Size(75, 23);
            this.GetMoviesButton.TabIndex = 0;
            this.GetMoviesButton.Text = "Get Movies";
            this.GetMoviesButton.UseVisualStyleBackColor = true;
            this.GetMoviesButton.Click += new System.EventHandler(this.GetMoviesButton_Click);
            // 
            // LeetCodeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 383);
            this.Controls.Add(this.GetMoviesButton);
            this.Name = "LeetCodeMainForm";
            this.Text = "LeetCode Katas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetMoviesButton;
    }
}

