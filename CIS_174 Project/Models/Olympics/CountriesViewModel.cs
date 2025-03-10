namespace CIS_174_Project.Models.Olympics
{
    public class CountriesViewModel
    {
        public Country Country { get; set; } = new Country();
        public string ActiveSportType { get; set; } = "all";
        public string ActiveGameType { get; set; } = "all";

        public List<Country> Countries { get; set; } = new List<Country>();
        public List<SportType> SportTypes { get; set; } = new List<SportType>();
        public List<GameType> GameTypes { get; set; } = new List<GameType>();

        public string CheckActiveSportType(string s) => s.ToLower() == ActiveSportType.ToLower() ? "active" : "";

        public string CheckActiveGameType(string g) => g.ToLower() == ActiveGameType.ToLower() ? "active" : "";
    }
}
