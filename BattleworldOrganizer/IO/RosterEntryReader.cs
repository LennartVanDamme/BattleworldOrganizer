using BattleworldOrganizer.Models;
using CsvHelper;
using System.Globalization;

namespace BattleworldOrganizer.IO
{
    public class RosterEntryReader
    {
        private const string filename = "roster.csv";
        
        public static List<RosterEntry> Read()
        {
            using StreamReader reader = new($".\\{filename}");
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<RosterEntryMap>();

            return csv.GetRecords<RosterEntry>().ToList();
        }
    }
}
