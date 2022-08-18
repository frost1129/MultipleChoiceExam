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
    public partial class formGV2 : Form
    {
        public formGV2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == false)
            {
                panelUser.Visible = true;
            }
            else
                panelUser.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
