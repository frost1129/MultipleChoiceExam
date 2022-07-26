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
    public partial class formMain : Form
    {
        public formMain()
        {
            formLogin f = new formLogin();
            f.ShowDialog();
            InitializeComponent();
        }
    }
}
