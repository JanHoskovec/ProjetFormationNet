using Newtonsoft.Json;
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
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string monUrlDeLapi = "http://localhost/DecouverteAPIWebAPI/api/Paragraphe";
                string monContenuVenantDuServeur = client.DownloadString(monUrlDeLapi);

                //Si on avait uniquement du XML en sortie:
                //System.Xml.Linq.XDocument doc = System.Xml.Linq.XDocument.Load(monUrlDeLapi);

                List<Models.ClasseDeTestJson> myList = JsonConvert.DeserializeObject<List<Models.ClasseDeTestJson>>(monContenuVenantDuServeur);

                foreach (var item in myList)
                {
                    Console.WriteLine((int)item.Numero);
                    Console.WriteLine(item.Contenu);
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
