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
    public partial class sv_TotalScores : Form
    {
        public sv_TotalScores()
        {
            InitializeComponent();

            ScrollBar hScrollBar1 = new HScrollBar();
            hScrollBar1.Dock = DockStyle.Bottom;
            hScrollBar1.Scroll += (sender, e) => { panel1.HorizontalScroll.Value = hScrollBar1.Value;};
            //panel1.Controls.Add(hScrollBar1);

            ScrollBar hScrollBar2 = new HScrollBar();
            hScrollBar2.Dock = DockStyle.Bottom;
            hScrollBar2.Scroll += (sender, e) => { panel2.HorizontalScroll.Value = hScrollBar2.Value; };
            //panel2.Controls.Add(hScrollBar2);
        }

        private void sV_Menu1_Load(object sender, EventArgs e)
        {

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
    }
}
