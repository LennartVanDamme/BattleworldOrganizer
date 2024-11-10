// See https://aka.ms/new-console-template for more information
using BattleworldOrganizer.IO;
using BattleworldOrganizer.Models;

Console.WriteLine("Hello, World!");


Dictionary<string, AllianceMember> allianceMembers = AllianceMemberReader.Read();
List<RosterEntry> rosterEntries = RosterEntryReader.Read();

foreach (RosterEntry entry in rosterEntries)
{
    if (!(allianceMembers.TryGetValue(entry.AllianceMember, out var allianceMember)))
        continue;

    allianceMember.AddToRoster(entry);
}

Console.WriteLine("All entries processed");