using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        UserBUS userBUS;

        public frmLogin()
        {
            InitializeComponent();
            userBUS = new UserBUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user;
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter username or password!");
                return;
            }
            if (!userBUS.ExistUsername(tbUsername.Text))
            {
                MessageBox.Show("Username is not exist!");
                return;
            }
            user = userBUS.GetUserByUserNameAndPassword(tbUsername.Text, tbPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Password is incorrect!");
                return;
            }

            frmInfo form = new frmInfo(user);
            this.Hide();
            tbPassword.Text = "";
            tbUsername.Text = "";
            form.ShowDialog();
            this.Show();
        }
    }
}
