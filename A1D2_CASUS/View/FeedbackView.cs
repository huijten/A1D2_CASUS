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
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();
        }

        private void FeedbackView_Load(object sender, EventArgs e)
        {
            Comboboxesfeedbackview();
            FeedBack fdb = new FeedBack();
            DataTable dtfb = fdb.Get2db4fdbck();
            FeedBase fbs = new FeedBase();
            DataTable dtfbs = fbs.Get2db4fdbs();
            DataTable Feedbaseback = new DataTable();
            //Feedbaseback.Merge(dtfb);
            //Feedbaseback.Merge(dtfbs);
            DGVFeedback.DataSource = dtfb;
        }
        public void RefreshDGVFb()
        {

        }
        public void Comboboxesfeedbackview()
        {
            //Assignmentselectie
            Assignment asg = new Assignment();
            var bindingSourceAssignment = new BindingSource();
            bindingSourceAssignment.DataSource = asg.Get2d4bAsnmt();
            FBCBXAssignment.DataSource = bindingSourceAssignment.DataSource;
            FBCBXAssignment.DisplayMember = "Name";
            FBCBXAssignment.ValueMember = "Id";
            //Superviser+Reviewerselectie
            Supervisor sprvis = new Supervisor();
            var bindingSourceSupervisor = new BindingSource();
            bindingSourceSupervisor.DataSource = sprvis.GetSupervisors();
            FBCBXSupervisor.DataSource = bindingSourceSupervisor.DataSource;
            FBCBXSupervisor.DisplayMember = "Name";
            FBCBXSupervisor.ValueMember = "Id";
            FBCBXReviewer.DataSource = bindingSourceSupervisor.DataSource;
            FBCBXReviewer.DisplayMember = "Name";
            FBCBXReviewer.ValueMember = "Id";
            //Studentselectie
            Student stdnt = new Student();
            var bindingSourceStudent = new BindingSource();
            bindingSourceStudent.DataSource = stdnt.GetStudentsdb();
            FBCBXStudent.DataSource = bindingSourceStudent.DataSource;
            FBCBXStudent.DisplayMember = "Name";
            FBCBXStudent.ValueMember = "Id";
        }

        private void Clearinputfields()
        {
            FBDTPCreatedate.Value = DateTime.Now;
            FBRTBContents.Text = string.Empty;
            FBRTBNotes.Text = string.Empty;
        }
        private void BTNCreate_Click(object sender, EventArgs e)
        {
            //FeedBaseDAO fbsdb = new FeedBaseDAO();
            FeedBackDAO fbdb = new FeedBackDAO();
            // FeedBase fbs = new FeedBase();
            FeedBack fb = new FeedBack();
            //DateTime creationDate = FBDTPCreatedate.Value;
            Assignment assignment = FBCBXAssignment.SelectedItem as Assignment;
            //Supervisor approvedBy = FBCBXSupervisor.SelectedValue as Supervisor;
            // S/tudent student = FBCBXStudent.SelectedValue as Student;
            //String content = FBRTBContents.Text;
            // int ID = fbs.GetlastFeedId();
            // FeedBase feed = (fbs) as FeedBase;
            string notes = FBRTBNotes.Text;
            int bonuspoints = FBTBBonuspoints.Value;
            //fb.CreateFdbck( assignment, notes, bonuspoints);
            //fb.CreateFdbck(feed, notes, bonuspoints);

        }

        private void FBCBXAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FBCBXSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FBCBXReviewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FBCBXStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
