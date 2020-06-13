using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.icndb.com/jokes.random";
            string response;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Class2 valueJSON = JsonConvert.DeserializeObject<Class2>(response);
            Console.WriteLine("Шутка: {0}", valueJSON.Joke);

            Console.ReadLine();
        }
    }
}
