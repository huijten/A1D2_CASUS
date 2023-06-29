using A1D2_CASUS.Model;
using A1D2_CASUS.View;
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
            string username = TXTLogin.Text;
            string password = TXTPassword.Text;
            if (username == "CasusgroepAfwezig" && password == "password")
            {
                MessageBox.Show("Login successful!");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }
    }
}
