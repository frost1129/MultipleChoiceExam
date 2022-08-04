using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceExam
{
    public partial class formGV : Form
    {
        public formGV()
        {
            InitializeComponent();
        }

        private void setMenuSlide(Button btn) // chạy thanh tiêu đề && hide exit menu
        {
            lbMenuSlide.Top = btn.Top;
            panelExit.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setMenuSlide(btnHome);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            setMenuSlide(btnAdd);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setMenuSlide(btnSetting);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (panelExit.Visible == false)
            {
                panelExit.Visible = true;
            }
            else
                panelExit.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin fl = new formLogin();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }
    }
}
