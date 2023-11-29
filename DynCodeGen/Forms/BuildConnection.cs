using DynCodeGen.UserControls;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DynCodeGen
{
    public partial class BuildConnection : Form
    {
        private readonly CreateControl _parent;
        public BuildConnection(CreateControl parent)
        {
            InitializeComponent();
            _parent = parent;
            txtPassword.Leave += txtPassword_TextChanged;
            lblDatabase.Hide();
            cmbDatabase.Hide();
            btnTestConnection.Hide();

        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            string ConnectionString = "Server=tcp:" + txtServerName.Text.ToString() + ",1433;Initial Catalog=" + cmbDatabase.Text.ToString() + ";Persist Security Info=False;User ID=" + txtUserName.Text.ToString() + ";Password=" + txtPassword.Text.ToString() + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            try
            {
                SqlConnection cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                btnTestConnection.Enabled = true;
                DialogResult result = MessageBox.Show("Connection Tested Succesfully !", "Success", MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {

                    _parent.txtConnectionString.Text = ConnectionString;
                    _parent.txtConnectionString.ReadOnly = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed! Please try with Valid credentials", "Failed", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (txtPassword.Text.Length > 0 && txtServerName.Text.Length > 0 && txtUserName.Text.Length > 0 && cmbAuthetication.Text.Length > 0)
            {
                try
                {


                    List<string> list = new List<string>();

                    string ConnectionString = "server=" + txtServerName.Text.ToString() + ";User Id=" + txtUserName.Text.ToString() + ";pwd=" + txtPassword.Text.ToString() + ";";

                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        cmbDatabase.Enabled = true;
                        btnTestConnection.Show();
                        using (SqlCommand cmd = new SqlCommand("SELECT name FROM master.dbo.sysdatabases", con))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    list.Add(dr[0].ToString());
                                }
                            }
                        }
                    }
                    cmbDatabase.DataSource = list;
                    this.Enabled = true;
                    lblDatabase.Show();
                    cmbDatabase.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Credentials");
                }


            }
            else
            {
                MessageBox.Show("please fill the ablove fields");
            }

        }
    }
}
