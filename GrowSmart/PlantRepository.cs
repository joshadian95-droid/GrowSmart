using System;
using System.Collections.Generic;
using System.Text.Json;

namespace GrowSmart
{
    internal static class PlantRepository
    {
        public static async Task<List<Plant>> LoadAsync()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "plants.json");

            await using var stream = File.OpenRead(path);
            var plants = await JsonSerializer.DeserializeAsync<List<Plant>>(stream) ?? new List<Plant>();

            // Keep only plants that have a days-to-maturity value
            return plants
                .Where(p => p.DaysToMaturityMin > 0 && p.DaysToMaturityMax > 0)
                .OrderBy(p => p.DisplayName)
                .ToList();
        }
    }
}
