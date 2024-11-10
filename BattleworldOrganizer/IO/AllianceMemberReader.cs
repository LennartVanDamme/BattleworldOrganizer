using BattleworldOrganizer.Models;
using CsvHelper;
using System.Globalization;

namespace BattleworldOrganizer.IO
{
    public class AllianceMemberReader
    {
        private const string filename = "info.csv";

        public static Dictionary<string, AllianceMember> Read()
        {
            using StreamReader reader = new($".\\{filename}");
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<AllianceMemberMap>();

            return csv.GetRecords<AllianceMember>().ToDictionary(member => member.Name);
        }
    }
}
