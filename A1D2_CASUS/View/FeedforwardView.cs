using A1D2_CASUS.Model;
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
    public partial class FeedforwardView : Form
    {
        FeedBase FBase { get; set; }
        public FeedforwardView()
        {
            InitializeComponent();
            PopulateComboBox();
            ResetLabels();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            FeedForward fd = new FeedForward();
            DataTable fdDT = fd.GetDataTables();
            dataGridView1.DataSource = fdDT;
        }

        private void ResetLabels()
        {
            supervisorLbl.Text = "";
            deadlineLbl.Text = "";
            contentLbl.Text = "";
            studentLbl.Text = "";
            assignmentLbl.Text = "";
        }

        private void PopulateComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Assignment db = new Assignment();
            bindingSourceAssignment.DataSource = db.Get2d4bAsnmt();
            assignmentComboBox.DataSource = bindingSourceAssignment;
            assignmentComboBox.DisplayMember = "Name";
            assignmentComboBox.ValueMember = "Id";
        }

        private void PopulateData(int assignmentId)
        {
            FeedBase db = new FeedBase();
            FeedBase feedBase = db.SearchByAssignment(assignmentId);
            FBase = feedBase;
            supervisorLbl.Text = feedBase.ApprovedBy.Name;
            deadlineLbl.Text = feedBase.CreationDate.ToString();
            contentLbl.Text = feedBase.Content;
            studentLbl.Text = feedBase.Student.Name;
            assignmentLbl.Text = feedBase.Assignment.Name;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            PopulateData(Int32.Parse(assignmentComboBox.SelectedValue.ToString()));
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            FeedForward ff = new FeedForward(0, FBase, notesTxtBox.Text);
            ff.Create(ff);
            MessageBox.Show("Succesfully Created!");
            LoadDataGrid();
        }
    }
}
