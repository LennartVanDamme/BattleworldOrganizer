namespace BattleworldOrganizer.Models
{
    public class AllianceMember
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Frame { get; set; }
        public int Level { get; set; }
        public int GearTier { get; set; }
        public string Tcp { get; set; }
        public string Stp { get; set; }
        public string WarMvp { get; set; }
        public string CharactersCollected { get; set; }
        public bool RosterShare { get; set; }
        public string DaysInAlliance { get; set; }


        private Dictionary<string, RosterEntry> _roster =  new Dictionary<string, RosterEntry>();

        public void AddToRoster(RosterEntry entry)
        {
            _roster.Add(entry.CharacterId, entry);
        }

    }
}
