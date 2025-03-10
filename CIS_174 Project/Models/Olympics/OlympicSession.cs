namespace CIS_174_Project.Models.Olympics
{
    public class OlympicSession
    {
        private const string CountriesKey = "myCountries";
        private const string CountKey = "countriesCount";
        private const string SportKey = "sport";
        private const string GameKey = "game";

        private ISession session {  get; set; }
        public OlympicSession(ISession session) => this.session = session;

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() => session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountriesCount() => session.GetInt32(CountKey);

        public void SetActiveSport(string activeSport) => session.SetString(SportKey, activeSport);
        public string GetActiveSport() => session.GetString(SportKey) ?? string.Empty;

        public void SetActiveGame(string activeGame) => session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey) ?? string.Empty;

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
