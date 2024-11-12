using BattleworldOrganizer.IO;
using BattleworldOrganizer.Models;
using BattleworldOrganizer.Models.Requirements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleworldOrganizer.Converters
{
    public class SpecOpsRequirementConverter
    {

        public BattleWorldSpecOps Convert(SpecialOpsRequirements requirements)
        {
            var battleWorldSpecOps = new BattleWorldSpecOps();

            var missionRequirements = ConvertDayRequirement(requirements.Day1.Mission1);

            var mission = new SpecOpsMission { Requirements = missionRequirements };

            battleWorldSpecOps.MissionsDay1.Add(mission);

            ConvertMissions(battleWorldSpecOps.MissionsDay1, requirements.Day1);


            return battleWorldSpecOps;
        }

        private void ConvertMissions(List<SpecOpsMission> missions, IEnumerable<DayRequirement> dayRequirements) 
        {
            missions.AddRange(dayRequirements
                .Select(ConvertDayRequirement)
                .Select(requirements => new SpecOpsMission { Requirements = requirements}));
        }

        private List<IMissionRequirement> ConvertDayRequirement(DayRequirement dayRequirement)
        {
            List<IMissionRequirement> requirements = [];

            foreach (var character in dayRequirement.Characters)
            {
                if (dayRequirement.RequirementType == "starrank")
                {
                    requirements.Add(new StarRankRequirement(character, dayRequirement.Requirement));
                }
                else if(dayRequirement.RequirementType == "geartier")
                {
                    requirements.Add(new GearTierLevelRequirement(character, dayRequirement.Requirement));
                }
            }

            return requirements;
        }
    }
}
