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
    public partial class AssignmentView : Form
    {
        public AssignmentView()
        {
            InitializeComponent();
            PopulateSTComboBox();
            PopulateSVComboBox();
        }
        private void AssignmentView_Load(object sender, EventArgs e)
        {
            Assignment asgnmt = new Assignment();
            DataTable Asgnmt = asgnmt.Get2d4bAsnmt();
            DGVAssignment.DataSource = Asgnmt;
        }
        public void RefreshDGVAs()
        {
            Assignment asnt = new Assignment();
            DGVAssignment.DataSource = null;
            DataTable Asgnmt = asnt.Get2d4bAsnmt();
            DGVAssignment.DataSource = Asgnmt;
            DGVAssignment.ResetBindings();
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
        # region CRud
        private void BTNCreate_Click(object sender, EventArgs e)
        {
            Assignment asnt = new Assignment(
                ATXTName.Text,
                ADTPDeadline.Value,
                ACBCompleted.Checked,
                ATBPoints.Value);
            asnt.CreateAsnmt(asnt);
            Supervisor approvedby = new Supervisor();
            Assignment assignment = new Assignment();
            Student student = new Student();
            Assignment tas = assignment.Search(assignment.lastid());
            var x = CBXSupervisor.SelectedValue.ToString();
            Supervisor has = approvedby.Search(Int32.Parse(x));
            CBXSupervisor.SelectedItem = approvedby;
            var s = CBXStudent.SelectedValue.ToString();
            Student stu = student.Search(Int32.Parse(s));
            CBXStudent.SelectedItem = student;
            DateTime creationDate = DateTime.UtcNow;
            string content = ATXTName.Text;
            FeedBase fbe = new FeedBase(creationDate, has, tas, stu, content);
            fbe.CRTfb(fbe);
            RefreshDGVAs();
            
        }
        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            Assignment asignmte = new Assignment();
            int id = Convert.ToInt32(DGVAssignment.SelectedRows[0].Cells["Id"].Value);
            string Name = ATXTName.Text;
            DateTime Deadline = ADTPDeadline.Value;
            bool isCompleted = ACBCompleted.Checked;
            int Points = ATBPoints.Value;
            asignmte.UpdateAsnmt(id, Name, Deadline, isCompleted, Points);
            RefreshDGVAs();
        }
        private void BTNDelete_Click(object sender, EventArgs e)
        {
            Assignment asignmte = new Assignment();
            int id = Convert.ToInt32(DGVAssignment.SelectedRows[0].Cells["Id"].Value);
            asignmte.DeleteAsnmt(id);
            RefreshDGVAs();
        }
        #endregion
    }
}
