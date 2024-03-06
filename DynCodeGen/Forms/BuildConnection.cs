using DynCodeGen.UserControls;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
        private readonly CreateControl _createControlParent;
        private readonly SpControl _spControlParent;
        private readonly CreateModelControl _createModelControlParent;
        private readonly AdoCreateControl _adoCreateControlParent;
        private readonly AdoEnhanceControl _adoEnhanceControlParent;
        public BuildConnection(CreateControl createControlParent, SpControl spControlParent, CreateModelControl createModelControlParent, AdoCreateControl adoCreateControlParent, AdoEnhanceControl adoEnhanceControlParent)
        {
            InitializeComponent();
            _createControlParent = createControlParent;
            _spControlParent = spControlParent;
            _createModelControlParent = createModelControlParent;
            _adoCreateControlParent = adoCreateControlParent;
            _adoEnhanceControlParent = adoEnhanceControlParent;
            txtPassword.Leave += txtPassword_TextChanged;

        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            string ConnectionString = "Server=" + txtServerName.Text.ToString() + ";Initial Catalog=" + cmbDatabase.Text.ToString() + ";Persist Security Info=False;User ID=" + txtUserName.Text.ToString() + ";Password=" + txtPassword.Text.ToString() + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
            try
            {
                if (txtPassword.Text.Length > 0 && txtServerName.Text.Length > 0 && txtUserName.Text.Length > 0 && cmbAuthetication.Text.Length > 0)
                {
                    SqlConnection cnn = new SqlConnection(ConnectionString);
                    cnn.Open();
                    btnTestConnection.Enabled = true;
                    DialogResult result = MessageBox.Show("Connection Tested Succesfully !", "Success", MessageBoxButtons.OK);

                    _createControlParent.txtConnectionString.Text = ConnectionString;
                    _createControlParent.txtConnectionString.ReadOnly = true;
                    _adoCreateControlParent.txtConnectionString.Text = ConnectionString;
                    _adoCreateControlParent.txtConnectionString.ReadOnly = true;           
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Please fill all the details", "Failed", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed! Please try with Valid credentials", "Failed", MessageBoxButtons.OK);
                this.Enabled = true;
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
                    //string ConnectionString = "Server=tcp:" + txtServerName.Text.ToString() + ",1433;Initial Catalog=" + cmbDatabase.Text.ToString() + ";Persist Security Info=False;User ID=" + txtUserName.Text.ToString() + ";Password=" + txtPassword.Text.ToString() + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

                    string ConnectionString = "server=" + txtServerName.Text.ToString() + ";User Id=" + txtUserName.Text.ToString() + ";pwd=" + txtPassword.Text.ToString() + ";Encrypt=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        cmbDatabase.Enabled = true;
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
                }
                catch (Exception ex)
                {
                    this.Enabled = true;
                    MessageBox.Show("Invalid Credentials");
                    txtPassword.Clear();
                }


            }
            else
            {
                this.Enabled = true;
                MessageBox.Show("please fill the ablove fields");
            }

        }
    }
}
