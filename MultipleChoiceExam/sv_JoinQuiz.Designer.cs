
namespace MultipleChoiceExam
{
    partial class sv_JoinQuiz
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
            this.sV_Menu1 = new MultipleChoiceExam.userControl.SV_Menu();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sV_Menu1
            // 
            this.sV_Menu1.BackColor = System.Drawing.Color.Transparent;
            this.sV_Menu1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sV_Menu1.Location = new System.Drawing.Point(0, 0);
            this.sV_Menu1.Name = "sV_Menu1";
            this.sV_Menu1.Size = new System.Drawing.Size(1080, 300);
            this.sV_Menu1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vào thi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 5);
            this.label3.TabIndex = 10;
            // 
            // sv_JoinQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sV_Menu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sv_JoinQuiz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sv_JoinQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControl.SV_Menu sV_Menu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}