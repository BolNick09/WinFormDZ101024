namespace Form_DZ_1
{
    partial class DZForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowResume = new Button();
            tbNumber = new TextBox();
            btnGuessNum = new Button();
            SuspendLayout();
            // 
            // btnShowResume
            // 
            btnShowResume.Location = new Point(12, 12);
            btnShowResume.Name = "btnShowResume";
            btnShowResume.Size = new Size(171, 29);
            btnShowResume.TabIndex = 0;
            btnShowResume.Text = "Показать резюме";
            btnShowResume.UseVisualStyleBackColor = true;
            btnShowResume.Click += btnShowResume_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(12, 61);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(171, 27);
            tbNumber.TabIndex = 1;
            // 
            // btnGuessNum
            // 
            btnGuessNum.FlatStyle = FlatStyle.System;
            btnGuessNum.Location = new Point(12, 94);
            btnGuessNum.Name = "btnGuessNum";
            btnGuessNum.Size = new Size(171, 29);
            btnGuessNum.TabIndex = 2;
            btnGuessNum.Text = "Угадать число";
            btnGuessNum.UseVisualStyleBackColor = true;
            btnGuessNum.Click += btnGuessNum_Click;
            // 
            // DZForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 135);
            Controls.Add(btnGuessNum);
            Controls.Add(tbNumber);
            Controls.Add(btnShowResume);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "DZForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Форма ДЗ 101024";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowResume;
        private TextBox tbNumber;
        private Button btnGuessNum;
    }
}
