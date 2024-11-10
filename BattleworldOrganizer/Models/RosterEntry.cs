namespace BattleworldOrganizer.Models
{
    public class RosterEntry
    {
        public string AllianceMember { get; set; }
        public string CharacterId { get; set; }
        public int Level { get; set; }
        public int Power { get; set; }
        public int Stars { get; set; }
        public int? RedStars { get; set; }
        public int GearTier { get; set; }
        public int? Basic { get; set; }
        public int? Special { get; set; }
        public int? Ultimate { get; set; }
        public int? Passive { get; set; }
        public string IsoClass { get; set; }
        public string IsoMatrix { get; set; }
        public int? Striker { get; set; }
        public int? Fortifier { get; set; }
        public int? Healer { get; set; }
        public int? Raider { get; set; }
        public int? Skirmisher { get; set; }
        public int? IsoHealth { get; set; }
        public int? IsoDamage { get; set; }
        public int? IsoArmor { get; set; }
        public int? IsoFocus { get; set; }
        public int? IsoResist { get; set; }

    }
}
