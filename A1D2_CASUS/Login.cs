using A1D2_CASUS.Model;
using A1D2_CASUS.View;
using A1D2_CASUS.DAO;
using System.ComponentModel;

namespace A1D2_CASUS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void BTNExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            Student dbs = new Student();
            Supervisor dbt = new Supervisor();
            string username = TXTLogin.Text;
            string password = TXTPassword.Text;

            bool isValid = dbs.validatestudent(username, password);
            bool isValid2 = dbt.validatesupervisor(username, password);
            if (isValid)
            {
                MessageBox.Show("Login successful!");
                Dashboard dashboard = new Dashboard();

                dashboard.Show();
                this.Hide();
            }
            else if (isValid2)
            {
                MessageBox.Show("Login successful!");
                Dashboard dashboard = new Dashboard();

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid loginnumber or password. Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
