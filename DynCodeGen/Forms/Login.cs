using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynCodeGen.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblValidation.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "ADMIN" && txtPassword.Text.Trim() == "ADMIN")
            {
                DynCodeGen frm = new DynCodeGen();
                this.Hide();
                frm.Show();
            }
            else
            {
                lblValidation.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
