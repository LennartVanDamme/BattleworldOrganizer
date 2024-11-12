using System;
using System.Linq;

namespace BattleworldOrganizer.Models.Requirements
{
    public abstract class SpecOpsMissionRequirement(string characterId, int requirement) : IMissionRequirement
    {
        public string CharacterId { get; } = characterId;

        public int Requirement { get; } = requirement;

        public abstract bool RequirementMet(AllianceMember member);
    }
}
