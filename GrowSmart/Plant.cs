using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GrowSmart
{
    public class MinMax
    {
        [JsonPropertyName("min")] public int? Min { get; set; }
        [JsonPropertyName("max")] public int? Max { get; set; }
    }
    internal class Plant
    {
        [JsonPropertyName("slug")] public string Slug { get; set; } = "";
        [JsonPropertyName("common_name")] public string DisplayName { get; set; } = "";
        [JsonPropertyName("scientific_name")] public string ScientificName { get; set; } = "";
        [JsonPropertyName("category")] public string Category { get; set; } = "";
        [JsonPropertyName("days_to_maturity")] public MinMax? DaysToMaturity { get; set; }
        [JsonPropertyName("maturity_from")] public string MaturityFrom { get; set; } = "";
        [JsonPropertyName("directions")] public string Directions { get; set; } = "";

        // Calculated values (not read from the file)
        [JsonIgnore] public int DaysToMaturityMin => DaysToMaturity?.Min ?? 0;
        [JsonIgnore] public int DaysToMaturityMax => DaysToMaturity?.Max ?? 0;
        [JsonIgnore] public int? OnlineDays { get; set; }   // only needed if you added the Trefle button
        [JsonIgnore] public int DaysToMaturityAverage => OnlineDays ?? (DaysToMaturityMin + DaysToMaturityMax) / 2;
        [JsonIgnore] public string DaysRange => $"{DaysToMaturityMin}-{DaysToMaturityMax}";
        [JsonIgnore] public string ListLabel => $"{DisplayName} - {Category}";
    }
}
