using System;
using System.Linq;

namespace BattleworldOrganizer.Models.Requirements
{
    public class StarRankRequirement(string characterId, int starRank) : SpecOpsMissionRequirement(characterId, starRank)
    {
        public override bool RequirementMet(AllianceMember member)
        {
            var character = member.GetCharacter(CharacterId);

            if (character is null)
                return false;

            return character.Stars >= Requirement;
        }
    }
}
