using A1D2_CASUS.Model;
using A1D2_CASUS.View;

namespace A1D2_CASUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Uncomment welke je wilt laten zien
            OpenChildForm(new DashboardView());

            //OpenChildForm(new RegisterView());

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
        }

        private void feedupBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedupView());
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedbackView());
        }

        private void feedforwardBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedforwardView());
        }

        private void assignmentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssignmentView());
        }

        private void feedguyBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedGuyView());
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShopView());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}