using A1D2_CASUS.DAO;
using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            PopulateASComboBox();
            PopulateSTComboBox();
            PopulateSVComboBox();
        }
        private void DashboardView_Load(object sender, EventArgs e)
        {
            FeedBase fdbase = new FeedBase();
            DataTable dtbfb = fdbase.Get2DB4FB();
            var BindDash = new BindingSource();
            BindDash.DataSource = dtbfb;
            DGVDash.DataSource = dtbfb;
        }
        #region  Populating & Refreshing
        private void PopulateASComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Assignment db = new Assignment();
            bindingSourceAssignment.DataSource = db.Get2d4bAsnmt();
            assignmentComboBox.DataSource = bindingSourceAssignment;

            assignmentComboBox.DisplayMember = "Name";
            assignmentComboBox.ValueMember = "Id";

        }
        private void PopulateSTComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Student db = new Student();
            bindingSourceAssignment.DataSource = db.Get2db4bST();
            CBXStudent.DataSource = bindingSourceAssignment;
            CBXStudent.DisplayMember = "Name";
            CBXStudent.ValueMember = "Id";
        }
        private void PopulateSVComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Supervisor db = new Supervisor();
            bindingSourceAssignment.DataSource = db.Get2db4SV();
            CBXSupervisor.DataSource = bindingSourceAssignment;
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.ValueMember = "Id";
        }
        public void RefreshDGVDash()
        {
            FeedBase fdbase = new FeedBase();
            DGVDash.DataSource = null;
            DataTable dtbfb = fdbase.Get2DB4FB();
            DGVDash.DataSource = dtbfb;
            DGVDash.ResetBindings();
        }
        #endregion

        #region CUD
        private void BTNCreate_Click(object sender, EventArgs e)
        {
            Supervisor approvedby = new Supervisor();
            Assignment assignment = new Assignment();
            Student student = new Student();
            var g = assignmentComboBox.SelectedValue.ToString();
            Assignment tas = assignment.Search(Int32.Parse(g));
            assignmentComboBox.SelectedItem = assignment;
            var x = CBXSupervisor.SelectedValue.ToString();
            Supervisor has = approvedby.Search(Int32.Parse(x));
            CBXSupervisor.SelectedItem = approvedby;
            var s = CBXStudent.SelectedValue.ToString();
            Student stu = student.Search(Int32.Parse(s));
            CBXStudent.SelectedItem = student;
            DateTime creationDate = DTPCreated.Value;
            string content = RTBContent.Text;
            FeedBase fbe = new FeedBase(creationDate, has, tas, stu, content);
            fbe.CRTfb(fbe);
            RefreshDGVDash();
        }
        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            FeedBase feedb = new FeedBase();
            int id = Convert.ToInt32(DGVDash.SelectedRows[0].Cells["Id"].Value);
            Supervisor approvedby = new Supervisor();
            Assignment assignment = new Assignment();
            Student student = new Student();
            var g = assignmentComboBox.SelectedValue.ToString();
            Assignment tas = assignment.Search(Int32.Parse(g));
            assignmentComboBox.SelectedItem = assignment;
            var x = CBXSupervisor.SelectedValue.ToString();
            Supervisor has = approvedby.Search(Int32.Parse(x));
            CBXSupervisor.SelectedItem = approvedby;
            var s = CBXStudent.SelectedValue.ToString();
            Student stu = student.Search(Int32.Parse(s));
            CBXStudent.SelectedItem = student;
            DateTime creationDate = DTPCreated.Value;
            string content = RTBContent.Text;
            feedb.UPDfb(id, creationDate, has, tas, stu, content);
            RefreshDGVDash();
        }
        private void BTNDelete_Click(object sender, EventArgs e)
        {
            FeedBase feedb = new FeedBase();
            int id = Convert.ToInt32(DGVDash.SelectedRows[0].Cells["Id"].Value);
            feedb.DELfb(id);
            RefreshDGVDash();
        }
        #endregion
    }
}
