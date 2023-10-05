public class SwapiService
{
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<Person> GetPersonAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        
        if (response.IsSuccessStatusCode)
        {
            Person person = await response.Content.ReadAsAsync<Person>();
            return person; 
        }
        
        return null; 
    }

    public async Task<Vehicle> GetVehicleAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        
        if (response.IsSuccessStatusCode)
        {
            Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
            return vehicle; 
        }
        
        return null; 
    }

    public async Task<Planet> GetPlanetAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        
        if (response.IsSuccessStatusCode)
        {
            Planet planet = await response.Content.ReadAsAsync<Planet>();
            return planet; 
        }
        
        return null; 
    }

    public async Task<Starship> GetStarshipAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        
        if (response.IsSuccessStatusCode)
        {
            Starship starship = await response.Content.ReadAsAsync<Starship>();
            return starship; 
        }
        
        return null; 
    }

    public async Task<T> GetAsync<T>(string url) where T: class
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        
        if (response.IsSuccessStatusCode)
        {
            //* Was success return
            T content = await response.Content.ReadAsAsync<T>();
            return content; 
        }
        //* Was not successfull
        return null; 
    }

    public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
    {
        HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people/?search=" + query);

        if (response.IsSuccessStatusCode)
        {
            //* Was success return
            return await response.Content.ReadAsAsync<SearchResult<Person>>();
            
        }
        //* Was not successfull
        return null; 
    }

    public async Task<SearchResult<Starship>> GetStarshipSearchAsync(string query)
    {
        HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/starships/?search=" + query);

        if (response.IsSuccessStatusCode)
        {
            //* Was success return
            return await response.Content.ReadAsAsync<SearchResult<Starship>>();
            
        }
        //* Was not successfull
        return null; 
    }

}

