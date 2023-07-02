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
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();
            PopulateComboBox();
            ResetLabels();
            LoadDataGrid();
            FillCBXSupervisor();
            FillCBXStudent();
        }

        private void LoadDataGrid()
        {
            FeedBack fb = new FeedBack();
            DataTable fbDT = fb.Get2d4bAsnmt();
            feedBackDataGridView.DataSource = fbDT;
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
        private void PopulateData(int assignmentId)
        {
            FeedBase db = new FeedBase();
            FeedBase feedBase = db.SearchByAssignment(assignmentId);

            supervisorLbl.Text = feedBase.ApprovedBy.Name;
            deadlineLbl.Text = feedBase.CreationDate.ToString();
            contentLbl.Text = feedBase.Content;
            studentLbl.Text = feedBase.Student.Name;
            assignmentLbl.Text = feedBase.Assignment.Name;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

            PopulateData(Int32.Parse(assignmentComboBox.SelectedValue.ToString()));
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
            string Not = TXTNotes.Text;
            fbb.CreateFeedbas(fb);
            FeedBase fbss = fb.SearchByAssignment(a);
            FeedBack fdb = new FeedBack(0, fbss, Not);
            fdb.MakeFeedback(fdb);
            MessageBox.Show("Succesfully Created!");
            LoadDataGrid();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Assignment asi = new Assignment();
            FeedBack asignmte = new FeedBack();
            int id = Convert.ToInt32(feedBackDataGridView.SelectedRows[0].Cells["Id"].Value);
            string Notes = TXTNotes.Text;
            int a = Int32.Parse(assignmentComboBox.SelectedValue.ToString());
            Assignment asif = asi.Search(a);
            FeedBase fb = new FeedBase();
            FeedBase fbss = fb.SearchByAssignment(a);
            asignmte.EditFeedback(id, fbss, Notes);
            MessageBox.Show("Succesfully Edited!");
            LoadDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assignment asi = new Assignment();
            FeedBack asignmte = new FeedBack();
            int id = Convert.ToInt32(feedBackDataGridView.SelectedRows[0].Cells["Id"].Value);
            asignmte.Delfedback(id);
            MessageBox.Show("Succesfully Removed!");
            LoadDataGrid();
        }
    }
}
