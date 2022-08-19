
namespace MultipleChoiceExam
{
    partial class gv_SettingQuiz
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
            this.gV_Menu1 = new MultipleChoiceExam.userControl.GV_Menu();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gV_Menu1
            // 
            this.gV_Menu1.BackColor = System.Drawing.Color.Transparent;
            this.gV_Menu1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gV_Menu1.Location = new System.Drawing.Point(0, 0);
            this.gV_Menu1.Name = "gV_Menu1";
            this.gV_Menu1.Size = new System.Drawing.Size(1080, 300);
            this.gV_Menu1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chỉnh sửa";
            // 
            // gv_SettingQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gV_Menu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gv_SettingQuiz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gv_SettingQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControl.GV_Menu gV_Menu1;
        private System.Windows.Forms.Label label1;
    }
}