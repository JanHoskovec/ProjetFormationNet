using MaSuperLibrarie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperLibrarie.Data_Layers
{
    public class ParagrapheDataLayer
    {
        public List<Paragraphe> GetAll()
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                //return (from item in context.Paragraphe
                //        orderby item.Numero
                //        select item).ToList();
                //is equivalent to the following:
                return context.Paragraphe.OrderBy(item => item.Numero).ToList();
            }
        }

        public Paragraphe GetOne(int id)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                return (from item in context.Paragraphe
                        where item.Id == id
                        select item).Single();

            }
        }

        public void Create(Paragraphe p)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                context.Paragraphe.Add(p);
                context.SaveChanges();
            }
        }

        public void Update(Paragraphe p)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                

            }
        }

        public void Delete(int id)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                context.Paragraphe.Remove((from para in context.Paragraphe
                                           where para.Id == id
                                           select para).Single());
                context.SaveChanges();
            }
        }
    }
}
