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
    public partial class FeedupView : Form
    {
        FeedBase FBase { get; set; }
        public FeedupView()
        {
            InitializeComponent();
            LoadDataGrid();
            FillCBXStudent();
            FillCBXSupervisor();
            PopulateComboBox();

        }
        private void FeedupView_Load(object sender, EventArgs e)
        {
            ResetLabels();
        }
        
        private void LoadDataGrid()
        {
            FeedUp fd = new FeedUp();
            DataTable fdDT = fd.GetFUPS();
            DGVFeedup.DataSource = fdDT;
        }

        private void ResetLabels()
        {
            supervisorLbl.Text = "";
            deadlineLbl.Text = "";
            contentLbl.Text = "";
            studentLbl.Text = "";
            assignmentLbl.Text = "";
        }
        public void FillCBXStudent()
        {
            var bind = new BindingSource();
            Student db = new Student();

            bind.DataSource = db.GetStudents();
            CBXStudent.DataSource = bind;
            CBXStudent.DisplayMember = "Name";
            CBXStudent.ValueMember = "Id";
        }
        public void FillCBXSupervisor()
        {
            var binda = new BindingSource();
            Supervisor db = new Supervisor();

            binda.DataSource = db.GetSupervisors();
            CBXSupervisor.DataSource = binda;
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.ValueMember = "Id";
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



        private void createBtn_Click(object sender, EventArgs e)
        {
            Assignment asi = new Assignment();
            Supervisor db = new Supervisor();
            FeedBase fbb = new FeedBase();
            Student stud = new Student();
            DateTime tijd = DateTime.Now;
            int ins = Int32.Parse(CBXSupervisor.SelectedValue.ToString());
            Supervisor supvis = db.Search(ins);
            int s = Int32.Parse(CBXStudent.SelectedValue.ToString());
            Student stu = stud.Search(s);
            int a = Int32.Parse(assignmentComboBox.SelectedValue.ToString());
            Assignment asif = asi.Search(a);
            FeedBase fb = new FeedBase(tijd, supvis,
            asif, stu, TXTContent.Text);
            string Not = notesTxtBox.Text;
            fbb.CreateFeedbas(fb);
            FeedBase fbss = fb.SearchByAssignment(a);
            FeedUp fu = new FeedUp(0, fbss, ATBPriority.Value, Not);
            fu.Createfup(fu);
            MessageBox.Show("FeedUp Created!");
            LoadDataGrid();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            PopulateData(Int32.Parse(assignmentComboBox.SelectedValue.ToString()));
        }
    }
}
