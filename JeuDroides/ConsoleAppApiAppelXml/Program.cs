using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppApiAppelXml
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string monUrlDeLapi = "http://localhost/DecouverteAPIWebAPI/api/Paragraphe";
                string monContenuVenantDuServeur = client.DownloadString(monUrlDeLapi);
                Console.WriteLine(monContenuVenantDuServeur);
                Console.ReadLine();
            }
        }
    }
}
