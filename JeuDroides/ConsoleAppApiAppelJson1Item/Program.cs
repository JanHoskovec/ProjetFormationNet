using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppApiAppelJson1Item
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Veuillez saisir le numéro du paragraphe souhaité :");
            int id = 0;
            bool valid = false;
            while (!valid)
                valid = int.TryParse(Console.ReadLine(), out id);

            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string myUrl = "http://localhost/DecouverteAPIWebAPI/api/paragraphe/" + id;
                string myContent = client.DownloadString(myUrl);
                Models.JsonContent myInstance = JsonConvert.DeserializeObject<Models.JsonContent>(myContent);
                Console.WriteLine((int)myInstance.Numero + ". ");
                Console.WriteLine(String.IsNullOrEmpty(myInstance.Titre) ? "" : myInstance.Titre);
                Console.WriteLine(myInstance.Contenu);
            }
            Console.ReadLine();

        }
    }
}
