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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                txtPassword.UseSystemPasswordChar = false;
            } else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Không được phép để trống username/password!", "Alert", MessageBoxButtons.OK);
                txtPassword.Clear();
                return;
            }

            if (txtPassword.Text == "admin")
            {
                if (cbType.SelectedIndex == 0)
                {
                    formGV f = new formGV();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                } else if (cbType.SelectedIndex == 1)
                {
                    formSV f = new formSV();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Phải lựa chọn User Type!", "Alert", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show("Sai password", "Alert", MessageBoxButtons.OK);
            }
        }
    }
}
