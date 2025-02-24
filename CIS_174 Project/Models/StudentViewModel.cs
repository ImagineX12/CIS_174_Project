namespace CIS_174_Project.Models
{
    public class StudentViewModel
    {
        public List<StudentModel> Students { get; set; } = new();
        public int AccessLevel { get; set; }

        public StudentViewModel(List<StudentModel> students, int accessLevel)
        {
            Students = students;
            AccessLevel = accessLevel;
        }
    }
}
