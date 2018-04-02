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
    public partial class frmInfo : Form
    {
        RightBUS rightBUS;
        UserGroupBUS userGroupBUS;
        User user;

        public frmInfo(User user)
        {
            InitializeComponent();
            rightBUS = new RightBUS();
            userGroupBUS = new UserGroupBUS();
            this.user = user;

        }

        void LoadUserInfo()
        {
            lbUsername.Text = user.UserName;
            lbFullname.Text = user.FullName;
            lbUserGroup.Text = userGroupBUS.GetGroupByUser(user).GroupName;
        }

        void LoadRoles()
        {
            List<Right> userRights = rightBUS.GetAllRightByUser(user);
            foreach (Right right in rightBUS.GetAllRights())
            {
                Button btn = new Button()
                {
                    Text = right.RightName,
                    Tag = right,
                    Enabled = userRights.Any(x => x.RightId == right.RightId)
                };
                btn.Click += BtnRight_Click;
                pnRoles.Controls.Add(btn);
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Right right = btn.Tag as Right;
            MessageBox.Show(right.Description);
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadRoles();
        }
    }
}
