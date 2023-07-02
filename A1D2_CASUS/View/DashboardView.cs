using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1D2_CASUS.View
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignmentDAO dAO = new AssignmentDAO();
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = dAO.GetLast();
            comboBox1.Items.Add(dAO.GetLast());
            dataGridView1.DataSource = dAO.GetLast();
        }
    }
}
