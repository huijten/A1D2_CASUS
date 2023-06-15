using A1D2_CASUS.Model;

namespace A1D2_CASUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            List<Outfit> o = new List<Outfit>();
            Student db = new Student(0, "", 0, "", o, 0, 0);

            List<Student> students = db.Read();

            string[] properties = { students[0].Id.ToString(), students[0].Name, students[0].StudentNumber.ToString(), students[0].Password, students[0].Outfits[0].Name, students[0].XP.ToString(), students[0].Level.ToString(), students[0].Points.ToString() };
           
            label1.Text = string.Join("\n", properties);
        }
    }
}