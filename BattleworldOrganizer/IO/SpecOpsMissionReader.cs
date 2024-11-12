using System;
using System.Collections;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BattleworldOrganizer.IO
{
    public class SpecOpsMissionReader
    {
        private string filePath = "mission-requirements.json";

        public SpecialOpsRequirements? Read()
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<SpecialOpsRequirements>(json);
        }
    }

    public class DayRequirement
    {
        [JsonPropertyName("requirementType")]
        public string RequirementType { get; set; }

        [JsonPropertyName("requirement")]
        public int Requirement { get; set; }

        [JsonPropertyName("characters")]
        public List<string> Characters { get; set; }
    }

    public class SpecialOpsRequirements
    {
        [JsonPropertyName("day1")]
        public SpecialOpsDayRequirements Day1 { get; set; }

        [JsonPropertyName("day2")]
        public SpecialOpsDayRequirements Day2 { get; set; }

        [JsonPropertyName("day3")]
        public SpecialOpsDayRequirements Day3 { get; set; }

        [JsonPropertyName("day4")]
        public SpecialOpsDayRequirements Day4 { get; set; }

        [JsonPropertyName("day5")]
        public SpecialOpsDayRequirements Day5 { get; set; }

        [JsonPropertyName("day6")]
        public SpecialOpsDayRequirements Day6 { get; set; }
    }

    public class SpecialOpsDayRequirements : IEnumerable<DayRequirement>
    {
        [JsonPropertyName("mission1")]
        public DayRequirement Mission1 { get; set; }

        [JsonPropertyName("mission2")]
        public DayRequirement Mission2 { get; set; }

        [JsonPropertyName("mission3")]
        public DayRequirement Mission3 { get; set; }

        [JsonPropertyName("mission4")]
        public DayRequirement Mission4 { get; set; }

        [JsonPropertyName("mission5")]
        public DayRequirement Mission5 { get; set; }

        [JsonPropertyName("mission6")]
        public DayRequirement Mission6 { get; set; }

        [JsonPropertyName("mission7")]
        public DayRequirement Mission7 { get; set; }

        [JsonPropertyName("mission8")]
        public DayRequirement Mission8 { get; set; }

        public IEnumerator<DayRequirement> GetEnumerator()
        {
            yield return Mission1;
            yield return Mission2;
            yield return Mission3;
            yield return Mission4;
            yield return Mission5;
            yield return Mission6;
            yield return Mission7;
            yield return Mission8;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
