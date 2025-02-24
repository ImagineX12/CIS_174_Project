namespace CIS_174_Project.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public StudentModel(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
