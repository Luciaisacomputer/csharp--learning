using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class DataObject
    {
        public string Name { get; set; }
    }

    public class Class1
    {
        private const string URL = "https://swapi.co/api/";
        
        private string endpoint = Console.ReadLine();

        static void Main(string[] args)
        {

            Console.WriteLine(@"                  ________________.  ___     .______  ");
            Console.WriteLine(@"                 /                | /   \    |   _  \");
            Console.WriteLine(@"                |   (-----|  |----`/  ^  \   |  |_)  |");
            Console.WriteLine(@"                 \   \    |  |    /  /_\  \  |      /");
            Console.WriteLine(@"            .-----)   |   |  |   /  _____  \ |  |\  \-------.");
            Console.WriteLine(@"            |________/    |__|  /__/     \__\| _| `.________|");
            Console.WriteLine(@"             ____    __    ____  ___     .______    ________.");
            Console.WriteLine(@"             \   \  /  \  /   / /   \    |   _  \  /        |");
            Console.WriteLine(@"              \   \/    \/   / /  ^  \   |  |_)  ||   (-----`");
            Console.WriteLine(@"               \            / /  /_\  \  |      /  \   \");
            Console.WriteLine(@"                \    /\    / /  _____  \ |  |\  \---)   |");
            Console.WriteLine(@"                 \__/  \__/ /__/     \__\|__| `._______/");
            Console.Write(new string('\n', 10)); 
            Console.WriteLine("Getting api data from the star wars api...");

            Task t = new Task(GetSwapi);
            t.Start();

            Console.ReadLine();
        }

        static async void GetSwapi()
        {
            string api = "https://swapi.co/api/";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(api))
            using (HttpContent content = response.Content)

            if (response.IsSuccessStatusCode)
            {
                    string result = await content.ReadAsStringAsync();
                    Console.WriteLine(result);
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("tada!");
                }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }
    }
}