using BattleworldOrganizer.Models;
using CsvHelper.Configuration;

namespace BattleworldOrganizer.IO
{
    public class RosterEntryMap : ClassMap<RosterEntry>
    {
        public RosterEntryMap()
        {
            Map(m => m.AllianceMember).Name("Name");
            Map(m => m.CharacterId).Name("Character Id");
            Map(m => m.Level).Name("Level");
            Map(m => m.Power).Name("Power");
            Map(m => m.Stars).Name("Stars");
            Map(m => m.RedStars).Name("Red Stars");
            Map(m => m.GearTier).Name("Gear Tier");
            Map(m => m.Basic).Name("Basic");
            Map(m => m.Special).Name("Special");
            Map(m => m.Ultimate).Name("Ultimate");
            Map(m => m.Passive).Name("Passive");
            Map(m => m.IsoClass).Name("ISO Class");
            Map(m => m.IsoMatrix).Name("ISO Matrix");
            Map(m => m.Striker).Name("Striker");
            Map(m => m.Fortifier).Name("Fortifier");
            Map(m => m.Healer).Name("Healer");
            Map(m => m.Raider).Name("Raider");
            Map(m => m.Skirmisher).Name("Skirmisher");
            Map(m => m.IsoHealth).Name("ISO Health");
            Map(m => m.IsoDamage).Name("ISO Damage");
            Map(m => m.IsoArmor).Name("ISO Armor");
            Map(m => m.IsoFocus).Name("ISO Focus");
            Map(m => m.IsoResist).Name("ISO Resist");
        }
    }
}
