using System.ComponentModel.DataAnnotations.Schema;

namespace CIS_174_Project.Models.Olympics
{
    public class Country
    {
        public string CountryID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public SportType SportType { get; set; } = null!;
        public GameType GameType { get; set; } = null!;
        public string CountryFlag {  get; set; } = string.Empty;
     }
}
