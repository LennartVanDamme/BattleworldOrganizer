using System;
using System.Linq;

namespace BattleworldOrganizer.Models.Requirements
{
    public interface IMissionRequirement
    {
        bool RequirementMet(AllianceMember member);
    }
}
