using A1D2_CASUS.Model;
using A1D2_CASUS.View;

namespace A1D2_CASUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            OpenChildForm(new DashboardView());

        }

        public Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childFormPanel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardView());
            titleLbl.Text = "DASHBOARD";
        }

        private void feedupBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssignmentView());
            titleLbl.Text = "ASSIGNMENT";
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedbackView());
            titleLbl.Text = "FEEDBACK";
        }

        private void feedforwardBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedforwardView());
            titleLbl.Text = "FEEDFORWARD";
        }

        private void assignmentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedupView());
            titleLbl.Text = "FEEDUP";
        }

        private void feedguyBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedGuyView());
            titleLbl.Text = "FEEDGUY";
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShopView());
            titleLbl.Text = "SHOP";
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paddingNavPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}