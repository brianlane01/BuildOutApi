using System.Text.Json.Serialization;
using Newtonsoft.Json;

HttpClient httpClient = new HttpClient();

var response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

if (response.IsSuccessStatusCode)
{
    // var content = response.Content.ReadAsStringAsync().Result;
    // var person = JsonConvert.DeserializeObject<Person>(content);

    Console.Clear();
    var luke = response.Content.ReadAsAsync<Person>().Result;

    Console.WriteLine(luke.Name);

    foreach (string vehicleUrl in luke.Vehicles)
    {
        HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
        Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;

        System.Console.WriteLine(vehicle.Name);
    }
}
SwapiService service = new SwapiService();

Person person = service.GetPersonAsync("https://swapi.dev/api/people/8").Result;
if (person != null)
{
    System.Console.WriteLine(person.Name);
}

foreach (string vehicleUrl in person.Vehicles)
{
    // HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
    var vehicle = service.GetVehicleAsync(vehicleUrl).Result;

    System.Console.WriteLine(vehicle.Name);
}

Person genericResponse = service.GetPersonAsync("https://swapi.dev/api/people/7").Result;
if (genericResponse != null)
{
    System.Console.WriteLine(genericResponse.Name);
    string planet = genericResponse.Planet;
    Planet planet2 = service.GetPlanetAsync(planet).Result;
    System.Console.WriteLine($"{genericResponse.Name}'s Homeworld is {planet2.Name}");
    foreach (string vehicleUrl in person.Vehicles)
    {
        // HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
        var vehicle = service.GetVehicleAsync(vehicleUrl).Result;

        System.Console.WriteLine(vehicle.Name);
    }
    // System.Console.WriteLine(genericResponse.Manufacturer);
}
SearchResult<Person> skywalker = service.GetPersonSearchAsync("skywalker").Result;
foreach (Person p in skywalker.Results)
{
    System.Console.WriteLine(p.Name);
    string planet = p.Planet;
    Planet planet3 = service.GetPlanetAsync(planet).Result;
    System.Console.WriteLine($"{p.Name}'s Homeworld is {planet3.Name}");
    foreach (string vehicleUrl in p.Vehicles)
    {
        // HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
        var vehicle = service.GetVehicleAsync(vehicleUrl).Result;

        System.Console.WriteLine(vehicle.Name);
    }
    List<string> starshipNames = new List<string>();
    foreach (string starshipUrl in p.Starships)
    {
        // HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
        var starship = service.GetStarshipAsync(starshipUrl).Result;
        starshipNames.Add(starship.Name);
    }
    // string starshipNamesString = string.Join(", ", starshipNames);
    // System.Console.WriteLine($"{p.Name}'s uses the following type of Starships: {starshipNamesString}");
    int starshipCount = starshipNames.Count;

    if (starshipCount == 0)
    {
        System.Console.WriteLine($"{p.Name} does not use any starships.");
    }
    else if (starshipCount == 1)
    {
        System.Console.WriteLine($"{p.Name} uses the following type of Starship: {starshipNames[0]}");
    }
    else
    {
        // Concatenate the starship names into a single string
        string starshipNamesString = string.Join(", ", starshipNames.GetRange(0, starshipCount - 1));
        starshipNamesString += $" and {starshipNames[starshipCount - 1]}";

        // Print the result
        System.Console.WriteLine($"{p.Name} uses the following types of Starships: {starshipNamesString}");
    }

}

SearchResult<Starship> imperialStarships = service.GetStarshipSearchAsync("imperial").Result;
List<string> starshipName1 = new List<string>();
foreach (Starship starship in imperialStarships.Results)
{
    starshipName1.Add(starship.Name);
    int starshipCount = starshipName1.Count;

    if (starshipCount == 0)
    {
        System.Console.WriteLine($"The Empire has not sent any starships yet.");
    }
    else if (starshipCount == 1)
    {
        System.Console.WriteLine($"The Empire has sent {starshipName1[0]}s to attack us.");
    }
    else
    {
        // Concatenate the starship names into a single string
        string starshipNamesString = string.Join(", ", starshipName1.GetRange(0, starshipCount - 1));
        starshipNamesString += $"s and {starshipName1[starshipCount - 1]}s";

        // Print the result
        System.Console.WriteLine($"The Empire has sent {starshipNamesString} to destroy us.");
    }
}


System.Console.WriteLine("Press Any Key To Continue");
Console.ReadKey();
