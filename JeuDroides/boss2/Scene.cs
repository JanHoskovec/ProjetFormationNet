using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    public class Scene
    {
        private string Texte;
        private int nbReponses = 0;
        private List<string> Answers = new List<string>();

        public Scene(string text)
        {
            this.Texte = text;
        }

        public void AddAnswer(string answer)
        {
            Answers.Add(answer);
            nbReponses++;
        }

        public void Display()
        {
            Console.WriteLine(Texte);
            for (int i = 0; i < nbReponses; i++)
            {
                Console.WriteLine($"\t{i+1} : {Answers[i]}");
            }
        }

        public int GetAnswer()
        {
            Console.WriteLine("\nQuelle est votre réponse ?");
            int i = -1;
            bool valid = false;
            while(!valid)
            {
                int.TryParse(Console.ReadLine(), out i);
                valid = (i > 0 && i <= nbReponses);
                if (!valid)
                    Program.DisplayInputError();
            }
            return i;
        }

    }
}
