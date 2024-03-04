using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Data;
using System.Diagnostics;
using System.Text;
using DynCodeGen.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DynCodeGen.Forms;

namespace DynCodeGen
{
    public partial class DynCodeGen : Form
    {
        private string folderPath = string.Empty;

        public DynCodeGen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        bool CreateProjectExpand = false;
        bool ExistingProjectExpand = false;
        private void CreateProjectTranstion_Tick(object sender, EventArgs e)
        {
            if (CreateProjectExpand == false)
            {
                CreateProjectContainer.Height += 10;
                if (CreateProjectContainer.Height >= 150)
                {
                    ExistingProjectExpand = false;
                    existingProjectContainer.Height = 50;
                    CreateProjectTranstion.Stop();
                    CreateProjectExpand = true;
                }
            }
            else
            {
                CreateProjectContainer.Height -= 10;
                if (CreateProjectContainer.Height <= 50)
                {
                    CreateProjectTranstion.Stop();
                    CreateProjectExpand = false;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FillHome();
            btnHome.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            CreateProjectTranstion.Start();
            FillHome();
        }

        public void FillHome()
        {
            ButtonSelectionBGChanged();
            lblHead.Text = "Home";
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.HomeControl();
            contentPanel.Controls.Add(activeControl);
        }
        public void ButtonSelectionBGChanged()
        {
            btnHome.BackColor = Color.FromArgb(29, 51, 92);
            btnCPEntityFrameworkCF.BackColor = Color.FromArgb(29, 51, 92);
            btnCP_ADO_SP.BackColor = Color.FromArgb(29, 51, 92);
            btnEP_EntityFramework_CF.BackColor = Color.FromArgb(29, 51, 92);
            btnEP_EntityFramework_SP.BackColor = Color.FromArgb(29, 51, 92);
            btn_EP_ADO_sp.BackColor = Color.FromArgb(29, 51, 92);
            btnCreateModel.BackColor = Color.FromArgb(29, 51, 92);
        }
        private void btnCP_ADO_SP_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            AdoCreatePanelUpdate(btnCP_ADO_SP.Text.ToString());
            btnCP_ADO_SP.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btn_EP_ADO_sp_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            AdoEnhancePanelUpdate(btn_EP_ADO_sp.Text.ToString());
            btn_EP_ADO_sp.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btnCPEntityFrameworkCF_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            CreatePanelUpdate(btnCPEntityFrameworkCF.Text.ToString());
            btnCPEntityFrameworkCF.BackColor = Color.FromArgb(107, 125, 157);
        }

        public void CreatePanelUpdate(string header)
        {
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.CreateControl();
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnCreateProject.Text} > {header}";
        }
        public void ExistingPanelUpdate(string header)
        {
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.SpControl(this);
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnExistingProject.Text} > {header}";
        }
        public void CreateModelPanelUpdate(string header)
        {
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.CreateModelControl(this);
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnCreateModel.Text} ";
        }

        public void AdoCreatePanelUpdate(string header)
        {
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.AdoCreateControl();
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnCreateProject.Text} > {header}";
        }
        public void AdoEnhancePanelUpdate(string header)
        {
            contentPanel.Controls.Clear();
            var activeControl = new UserControls.AdoEnhanceControl();
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnExistingProject.Text} > {header}";
        }

        private void DynCodeGen_Load(object sender, EventArgs e)
        {
            var myControl = new UserControls.HomeControl();
            contentPanel.Controls.Add(myControl);
        }

        private void existingProjectTanstion_Tick(object sender, EventArgs e)
        {
            if (ExistingProjectExpand == false)
            {
                existingProjectContainer.Height += 10;
                if (existingProjectContainer.Height >= 200)
                {
                    CreateProjectExpand = false;
                    CreateProjectContainer.Height = 50;
                    existingProjectTanstion.Stop();
                    ExistingProjectExpand = true;
                }
            }
            else
            {
                existingProjectContainer.Height -= 10;
                if (existingProjectContainer.Height <= 50)
                {
                    existingProjectTanstion.Stop();
                    ExistingProjectExpand = false;
                }
            }
        }

        private void btnExistingProject_Click(object sender, EventArgs e)
        {
            existingProjectTanstion.Start();
            FillHome();
        }


        private void btnEP_EntityFramework_CF_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            ExistingPanelUpdate(btnEP_EntityFramework_CF.Text.ToString());
            btnEP_EntityFramework_CF.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btnEP_EntityFramework_SP_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            ExistingPanelUpdate(btnEP_EntityFramework_SP.Text.ToString());
            btnEP_EntityFramework_SP.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            CreateModelPanelUpdate(btnCreateModel.Text.ToString());
            btnCreateModel.BackColor = Color.FromArgb(107, 125, 157);
        }
    }
}
