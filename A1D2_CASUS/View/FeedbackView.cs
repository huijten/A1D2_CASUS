using A1D2_CASUS.DAO;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace A1D2_CASUS.View
{
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();
            PopulateASComboBox();
            PopulateSTComboBox();
            PopulateSVComboBox();
            //RefreshDGVFB();
            PopulateLB();

        }
        #region Populate&Refresh
        private void PopulateASComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Assignment db = new Assignment();
            bindingSourceAssignment.DataSource = db.Get2d4bAsnmt();
            assignmentComboBox.DataSource = bindingSourceAssignment;
            assignmentComboBox.DisplayMember = "Name";
            assignmentComboBox.ValueMember = "Id";
        }
        public void RefreshDGVFB()
        {
            FeedBase fb = new FeedBase();
            FeedBack feb = new FeedBack();
            DGVFBS.DataSource = null;

            
            DataTable DT = fb.Get2DB4FB();

            
            DGVFBS.ResetBindings();

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
        
        private void PopulateLB()
        {
            FeedBase fdb = new FeedBase();
            LBFBS.DataSource = fdb.RDLIST();
            object selectedObject = LBFBS.SelectedItem;
            LBFBS.DisplayMember = fdb.SeeIds;
            LBFBS.ValueMember = "Id";
        }
        private void PopulateData(int assignmentId)
        {
            FeedBase db = new FeedBase();
            FeedBase feedBase = db.SearchByAssignment(assignmentId);

            CBXSupervisor.Text = feedBase.ApprovedBy.Name;
            deadlineLbl.Text = feedBase.CreationDate.ToString();
            RTBContents.Text = feedBase.Content;
            CBXStudent.Text = feedBase.Student.Name;
        }
        #endregion

        #region CRUD
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            PopulateData(Int32.Parse(assignmentComboBox.SelectedValue.ToString()));
        }


        #endregion

        private void DGVFBS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            FeedBase Feed= new FeedBase();
            FeedBack fbs = new FeedBack();
            int ok = LBFBS.TabIndex = 0;
            var fb = Feed.Search(ok);
             Feed = (FeedBase)LBFBS.SelectedItem;
            string note = RTBNotes.Text;
           // var fete = (LBFBS.AccessibleName.Split(',')[0], het.Id);
            fbs.Addfedback(fb, note);
        }
    }
}
