using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    // Entry point for the application
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting HTTP Client Demo...");

        // Step 1: Initialize HttpClient
        using HttpClient client = new HttpClient();

        // Step 2: Set the base URL (optional if you're working with multiple endpoints)
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

        // Step 3: Send a GET request
        HttpResponseMessage response = await client.GetAsync("/posts/1");

        // Step 4: Check if the response is successful
        if (response.IsSuccessStatusCode)
        {
            // Step 5: Read response content as a string
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response from API: ");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"Request failed with status code: {response.StatusCode}");
        }

        // Step 6: Dispose of HttpClient (handled by the `using` statement)
    }
}
