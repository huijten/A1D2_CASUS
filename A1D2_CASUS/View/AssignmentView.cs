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
        #region loading&filling&populating
        public AssignmentView()
        {
            InitializeComponent();
        }
        private void AssignmentView_Load(object sender, EventArgs e)
        {
            RefreshDGVAs();
            FillCBXSupervisor();
            FillCBXStudent();
        }
        public void RefreshDGVAs()
        {
            Assignment asnt = new Assignment();
            DGVAssignment.DataSource = null;
            DataTable Asgnmt = asnt.Get2d4bAsnmt();
            DGVAssignment.DataSource = Asgnmt;
            DGVAssignment.ResetBindings();
        }
        public void FillCBXStudent()
        {
            var bind = new BindingSource();
            Student db = new Student();
            bind.DataSource = null;
            bind.DataSource = db.GetStudents();
            CBXStudent.DataSource = bind;
            CBXStudent.DisplayMember = "Name";
            CBXStudent.ValueMember = "Id";
        }
        public void FillCBXSupervisor()
        {
            var binda = new BindingSource();
            Supervisor db = new Supervisor();
            binda.DataSource = null;
            binda.DataSource = db.GetSupervisors();
            CBXSupervisor.DataSource = binda;
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.ValueMember = "Id";
        }
#endregion

        #region CRud
        private void BTNCreate_Click(object sender, EventArgs e)
        {
            Supervisor db = new Supervisor();
            FeedBase fbb = new FeedBase();
            Assignment asnt = new Assignment(
                ATXTName.Text,
                ADTPDeadline.Value,
                ACBCompleted.Checked,
                ATBPoints.Value);
            asnt.CreateAsnmt(asnt);
            Assignment ast = new Assignment();
           // DateTime tijd = DateTime.Today;
            //int t = CBXSupervisor.SelectedValue.; Supervisor super = new Supervisor(); 
           // Supervisor deze = super.Search(t);
            //var s = CBXStudent.SelectedValue;
           // FeedBase fb = new FeedBase(0, tijd, CBXSupervisor.SelectedValue as Supervisor,
            //ast.Getlastassign(), CBXStudent.SelectedItem as Student, ATXTName.Text);
           // fbb.CreateFeedbas(fb);
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
