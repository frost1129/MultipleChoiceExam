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
    public partial class sv_Quizzz : Form
    {
        public sv_Quizzz()
        {
            InitializeComponent();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == true)
                panelUser.Visible = false;
            else
                panelUser.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
