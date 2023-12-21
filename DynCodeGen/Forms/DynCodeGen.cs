using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Data;
using System.Diagnostics;
using System.Text;
using DynCodeGen.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Close();
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
            btnCPWithEntity.BackColor = Color.FromArgb(29, 51, 92);
            btnCPWithoutEntity.BackColor = Color.FromArgb(29, 51, 92);
        }
        private void btnCPWithoutEntity_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            CreatePanelUpdate(btnCPWithoutEntity.Text.ToString());
            btnCPWithoutEntity.BackColor = Color.FromArgb(107, 125, 157);
        }

        private void btnCPWithEntity_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            CreatePanelUpdate(btnCPWithEntity.Text.ToString());
            btnCPWithEntity.BackColor = Color.FromArgb(107, 125, 157);
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
            var activeControl = new UserControls.SpControl();
            contentPanel.Controls.Add(activeControl);
            lblHead.Text = $"{btnCreateProject.Text} > {header}";
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
                if (existingProjectContainer.Height >= 150)
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

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEPWithEntity_Click(object sender, EventArgs e)
        {
            ButtonSelectionBGChanged();
            ExistingPanelUpdate(btnEPWithEntity.Text.ToString());
            btnEPWithEntity.BackColor = Color.FromArgb(107, 125, 157);
        }
    }
}
