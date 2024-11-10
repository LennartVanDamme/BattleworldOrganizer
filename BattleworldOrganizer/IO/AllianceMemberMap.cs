using BattleworldOrganizer.Models;
using CsvHelper.Configuration;

namespace BattleworldOrganizer.IO
{
    public class AllianceMemberMap : ClassMap<AllianceMember>
    {
        public AllianceMemberMap()
        {
            Map(m => m.Id).Name("ID");
            Map(m => m.Rank).Name("Rank");
            Map(m => m.Name).Name("Name");
            Map(m => m.Icon).Name("Icon");
            Map(m => m.Frame).Name("Frame");
            Map(m => m.Level).Name("Level");
            Map(m => m.GearTier).Name("Gear Tier");
            Map(m => m.Tcp).Name("TCP");
            Map(m => m.Stp).Name("STP");
            Map(m => m.WarMvp).Name("War MVP");
            Map(m => m.CharactersCollected).Name("Characters Collected");
            Map(m => m.RosterShare)
                .Name("Roster Share")
                .TypeConverterOption.BooleanValues(true, true, "true")
                .TypeConverterOption.BooleanValues(false, true, "");
            Map(m => m.DaysInAlliance).Name("Days In Alliance");
        }
    }
}
