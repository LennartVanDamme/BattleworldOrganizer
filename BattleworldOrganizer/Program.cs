// See https://aka.ms/new-console-template for more information
using BattleworldOrganizer.IO;
using BattleworldOrganizer.Models;
using BattleworldOrganizer.Models.Requirements;

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

var missionRequirements = new SpecOpsMissionReader().Read();

foreach(var specialOpsDayRequirements in missionRequirements)
{
    foreach(var dayRequirement in specialOpsDayRequirements)
    {
        dayRequirement.Characters.ConvertAll(character => 
        {
            if(dayRequirement.RequirementType == "starrank")
            {
                return new StarRankRequirement(character) { StarRank = dayRequirement.Requirement };
            }else
            {
                return new 
            }
        });
    }
}

Console.WriteLine("Write");