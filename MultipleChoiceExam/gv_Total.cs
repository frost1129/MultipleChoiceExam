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
    public partial class gv_Total : Form
    {
        public gv_Total()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == true)
                panelUser.Visible = false;
            else
                panelUser.Visible = true;
        }
    }
}
