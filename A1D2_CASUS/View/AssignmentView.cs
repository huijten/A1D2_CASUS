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
        # region CRud
        private void BTNCreate_Click(object sender, EventArgs e)
        {
            Assignment asnt = new Assignment(
                ATXTName.Text,
                ADTPDeadline.Value,
                ACBCompleted.Checked,
                ATBPoints.Value);
            asnt.CreateAsnmt(asnt);
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
