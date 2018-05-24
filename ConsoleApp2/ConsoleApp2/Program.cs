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

        static void Main(string[] args)
        {
            Task t = new Task(GetSwapi);
            t.Start();
            Console.WriteLine("Getting data...");
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
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }
    }
}