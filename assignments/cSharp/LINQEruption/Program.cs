// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");


// Execute Assignment Tasks here!

Eruption firstEruptionInChile = eruptions.FirstOrDefault(c => c.Location == "Chile");
Console.WriteLine(firstEruptionInChile.ToString());

// Shows each eruption in Chile
// IEnumerable<Eruption> locationEruptions = eruptions.Where(e => e.Location == "Chile");
// PrintEach(locationEruptions, "First eruption in Chile");
Console.WriteLine("----------------------------------------");


Eruption hawaiiEruption = eruptions.FirstOrDefault(h => h.Location == "Hawaiian Is");
if (hawaiiEruption != null)
{
    Console.WriteLine(hawaiiEruption.ToString());
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}


Console.WriteLine("----------------------------------------");


Eruption newZealand = eruptions.Where(erupt => erupt.Location == "New Zealand")
                        .FirstOrDefault(erupt => erupt.Year > 1900);
Console.WriteLine($"First Eruption after 1900 that is in New Zealand: {newZealand.ToString()}");


Console.WriteLine("----------------------------------------");


IEnumerable<Eruption> elevationEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(elevationEruptions, "Over 2000m elevation eruptions:");


Console.WriteLine("----------------------------------------");


IEnumerable<Eruption> lNameEruptions = eruptions.Where(n => n.Volcano.StartsWith("L")).ToList();
PrintEach(lNameEruptions, "Volcanos with names that start with 'L'");
Console.WriteLine(format: $"Number of Volcanos with 'L' names : {lNameEruptions.Count()}");


Console.WriteLine("----------------------------------------");


int highestElevation = eruptions.Max(h => h.ElevationInMeters);
Console.WriteLine($"Highest Elevation : {highestElevation}");


Console.WriteLine("----------------------------------------");


Eruption highestVolcano = eruptions.FirstOrDefault(v => v.ElevationInMeters == highestElevation);
Console.WriteLine($"The highest Volcano Name : {highestVolcano.Volcano}");


Console.WriteLine("----------------------------------------");


IEnumerable<Eruption> aBCVolcano = eruptions.OrderBy(a => a.Volcano);
PrintEach(aBCVolcano, "Volcanos in ABC order :");


Console.WriteLine("----------------------------------------");


IEnumerable<Eruption> Pre1000 = eruptions.Where(b => b.Year < 1000)
                                        .OrderBy(b => b.Volcano);
PrintEach(Pre1000, "Eruptions pre Year 1000CE ABC Order");


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

