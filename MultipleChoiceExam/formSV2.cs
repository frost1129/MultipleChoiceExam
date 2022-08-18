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
    public partial class formSV2 : Form
    {
        public formSV2()
        {
            InitializeComponent();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == false)
            {
                panelUser.Visible = true;
            }
            else
                panelUser.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
