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
            this.CoderpadSquareButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LeetCodeTabPage = new System.Windows.Forms.TabPage();
            this.CompaniesTabPage = new System.Windows.Forms.TabPage();
            this.CodilityCantaloupeButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ExercisesTabPage = new System.Windows.Forms.TabPage();
            this.FizzBuzzButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CompaniesTabPage.SuspendLayout();
            this.ExercisesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetMoviesButton
            // 
            this.GetMoviesButton.Location = new System.Drawing.Point(6, 6);
            this.GetMoviesButton.Name = "GetMoviesButton";
            this.GetMoviesButton.Size = new System.Drawing.Size(154, 23);
            this.GetMoviesButton.TabIndex = 0;
            this.GetMoviesButton.Text = "Get Movies (TripleByte)";
            this.GetMoviesButton.UseVisualStyleBackColor = true;
            this.GetMoviesButton.Click += new System.EventHandler(this.GetMoviesButton_Click);
            // 
            // CoderpadSquareButton
            // 
            this.CoderpadSquareButton.Location = new System.Drawing.Point(6, 35);
            this.CoderpadSquareButton.Name = "CoderpadSquareButton";
            this.CoderpadSquareButton.Size = new System.Drawing.Size(154, 23);
            this.CoderpadSquareButton.TabIndex = 1;
            this.CoderpadSquareButton.Text = "CoderPad (Square)";
            this.CoderpadSquareButton.UseVisualStyleBackColor = true;
            this.CoderpadSquareButton.Click += new System.EventHandler(this.CoderpadSquareButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LeetCodeTabPage);
            this.tabControl1.Controls.Add(this.CompaniesTabPage);
            this.tabControl1.Controls.Add(this.ExercisesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 168);
            this.tabControl1.TabIndex = 2;
            // 
            // LeetCodeTabPage
            // 
            this.LeetCodeTabPage.Location = new System.Drawing.Point(4, 22);
            this.LeetCodeTabPage.Name = "LeetCodeTabPage";
            this.LeetCodeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LeetCodeTabPage.Size = new System.Drawing.Size(662, 142);
            this.LeetCodeTabPage.TabIndex = 0;
            this.LeetCodeTabPage.Text = "LeetCode";
            this.LeetCodeTabPage.UseVisualStyleBackColor = true;
            // 
            // CompaniesTabPage
            // 
            this.CompaniesTabPage.Controls.Add(this.CodilityCantaloupeButton);
            this.CompaniesTabPage.Controls.Add(this.GetMoviesButton);
            this.CompaniesTabPage.Controls.Add(this.CoderpadSquareButton);
            this.CompaniesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CompaniesTabPage.Name = "CompaniesTabPage";
            this.CompaniesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompaniesTabPage.Size = new System.Drawing.Size(662, 142);
            this.CompaniesTabPage.TabIndex = 1;
            this.CompaniesTabPage.Text = "Companies";
            this.CompaniesTabPage.UseVisualStyleBackColor = true;
            // 
            // CodilityCantaloupeButton
            // 
            this.CodilityCantaloupeButton.Location = new System.Drawing.Point(6, 64);
            this.CodilityCantaloupeButton.Name = "CodilityCantaloupeButton";
            this.CodilityCantaloupeButton.Size = new System.Drawing.Size(154, 23);
            this.CodilityCantaloupeButton.TabIndex = 2;
            this.CodilityCantaloupeButton.Text = "Codility (Cantaloupe)";
            this.CodilityCantaloupeButton.UseVisualStyleBackColor = true;
            this.CodilityCantaloupeButton.Click += new System.EventHandler(this.CodilityCantaloupeButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 186);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(670, 305);
            this.ResultsTextBox.TabIndex = 3;
            // 
            // ExercisesTabPage
            // 
            this.ExercisesTabPage.Controls.Add(this.FizzBuzzButton);
            this.ExercisesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ExercisesTabPage.Name = "ExercisesTabPage";
            this.ExercisesTabPage.Size = new System.Drawing.Size(662, 142);
            this.ExercisesTabPage.TabIndex = 2;
            this.ExercisesTabPage.Text = "Exercises";
            this.ExercisesTabPage.UseVisualStyleBackColor = true;
            // 
            // FizzBuzzButton
            // 
            this.FizzBuzzButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FizzBuzzButton.Location = new System.Drawing.Point(6, 6);
            this.FizzBuzzButton.Name = "FizzBuzzButton";
            this.FizzBuzzButton.Size = new System.Drawing.Size(154, 23);
            this.FizzBuzzButton.TabIndex = 1;
            this.FizzBuzzButton.Text = "FizzBuzz";
            this.FizzBuzzButton.UseVisualStyleBackColor = true;
            this.FizzBuzzButton.Click += new System.EventHandler(this.FizzBuzzButton_Click);
            // 
            // LeetCodeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 503);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "LeetCodeMainForm";
            this.Text = "LeetCode Katas";
            this.tabControl1.ResumeLayout(false);
            this.CompaniesTabPage.ResumeLayout(false);
            this.ExercisesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetMoviesButton;
        private System.Windows.Forms.Button CoderpadSquareButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LeetCodeTabPage;
        private System.Windows.Forms.TabPage CompaniesTabPage;
        private System.Windows.Forms.Button CodilityCantaloupeButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.TabPage ExercisesTabPage;
        private System.Windows.Forms.Button FizzBuzzButton;
    }
}

