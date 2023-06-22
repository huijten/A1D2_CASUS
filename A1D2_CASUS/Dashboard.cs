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
            OpenChildForm(new LoginView());

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
    }
}