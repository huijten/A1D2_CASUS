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
        internal Student student = new Student(0, "", 0, "");
        internal Supervisor supervisor = new Supervisor(0, "", "", "");
        internal Assignment assignm = new Assignment(0, "", DateTime.Now, true, 0);
        public DashboardView()
        {
            InitializeComponent();
        }
        #region vulfuncties
        private void DashboardView_Load(object sender, EventArgs e)
        {
            Comboboxesfeedbackview();
            Assignment asgm = new Assignment();
            FeedBase fedb = new FeedBase();
            // DGVFeed.DataSource = null;
            DataTable dtfbs = fedb.Get2db4fdbs();
            DGVFeed.DataSource = dtfbs;
            // DGVFeed.ResetBindings();
            DataTable dta = asgm.Get2d4bAsnmt();
            DBLBAssignments.DataSource = dta;
        }

        public void Comboboxesfeedbackview()
        {
            //Superviser+Reviewerselectie
            Supervisor sprvis = new Supervisor();
            Supervisor sprvi = new Supervisor();
            var bindingSourceSupervisor = new BindingSource();
            var windingSourceReviewer = new BindingSource();
            bindingSourceSupervisor.DataSource = sprvis.GetSupervisors();
            windingSourceReviewer.DataSource = sprvi.GetSupervisors();
            DBCBXSupervisor.DataSource = bindingSourceSupervisor.DataSource;
            DBCBXSupervisor.DisplayMember = "Name";
            DBCBXSupervisor.ValueMember = "Id";
            DBCBXReviewer.DataSource = windingSourceReviewer.DataSource;
            DBCBXReviewer.DisplayMember = "Name";
            DBCBXReviewer.ValueMember = "Id";
            //Studentselectie
            Student stdnt = new Student();
            var bindingSourceStudent = new BindingSource();
            bindingSourceStudent.DataSource = stdnt.GetStudentsdb();
            DBCBXStudent.DataSource = bindingSourceStudent.DataSource;
            DBCBXStudent.DisplayMember = "Name";
            DBCBXStudent.ValueMember = "Id";
        }
        #endregion
        public class SupervisorA
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string WorkNumber { get; set; }
            public string Password { get; set; }
            // Other attributes of ObjectA
        }



        private void BTNCreate_Click(object sender, EventArgs e)
        {
            FeedBaseDAO fbsdb = new FeedBaseDAO();
            Supervisor supervisie = new Supervisor();
            SupervisorA approvedById = new SupervisorA();
            FeedBase feedBase = new FeedBase();
            DateTime creationdate = DBDTPCreatedate.Value;
            //DBCBXReviewer.SelectedItem as Supervisor,
            //DBCBXSupervisor.SelectedItem as Supervisor;
            Assignment AssignmentId = DBLBAssignments.SelectedItem as Assignment;
            Student student = DBCBXStudent.SelectedItem as Student;
            string content = DBRTBContents.Text; fbsdb.CreateFeedbase(creationdate, AssignmentId, student, content);






            // int ID = fbs.GetlastFeedId();
            // FeedBase feed = (fbs) as FeedBase;
            //string notes = FBRTBNotes.Text;
            //int bonuspoints = FBTBBonuspoints.Value;
            // fbs.CreateFdbs(creationDate, assignment, student, content);
        }
    }
}
