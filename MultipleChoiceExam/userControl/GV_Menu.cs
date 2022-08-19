using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceExam.userControl
{
    public partial class GV_Menu : UserControl
    {
        public GV_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == false)
            {
                panelUser.Visible = true;
            }
            else
                panelUser.Visible = false;
        }
    }
}
