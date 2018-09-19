using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JeuDroides.Core.Models
{
    public class Question : Texte
    {
        public List<Reponse> MesReponses { get; set; }        
    }
}