using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAppelPost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient { Encoding = Encoding.UTF8 })
            {
                NameValueCollection monDico = new NameValueCollection();
                monDico["Contenu"] = "Check one two three";
                monDico["Titre"] = "Soundcheck";
                monDico.Add("Numero", "69");//mixing two syntaxes here

                client.UploadValues("http://localhost/DecouverteAPIWebAPI/api/Paragraphe", monDico);
            }
        }
    }
}
