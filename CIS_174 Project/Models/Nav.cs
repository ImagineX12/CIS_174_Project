namespace CIS_174_Project.Models
{
    public class Nav
    {
        public static string Active(string expectedAction, string actualAction)
        {
            return (expectedAction == actualAction) ? "active" : "";
        }
    }
}
