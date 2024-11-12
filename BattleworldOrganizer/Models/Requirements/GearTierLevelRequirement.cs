using System;
using System.Linq;

namespace BattleworldOrganizer.Models.Requirements
{
    public class GearTierLevelRequirement(string characterId, int requirement)
        : SpecOpsMissionRequirement(characterId, requirement)
    {

        public override bool RequirementMet(AllianceMember member)
        {
            var character = member.GetCharacter(CharacterId);

            if (character is null)
                return false;

            return character.GearTier >= Requirement;
        }
    }
}
