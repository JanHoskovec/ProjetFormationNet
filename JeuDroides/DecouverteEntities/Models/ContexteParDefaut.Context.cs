﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DecouverteEntities.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JeuDroideEntities : DbContext
    {
        public JeuDroideEntities()
            : base("name=JeuDroideEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Droide> Droide { get; set; }
        public virtual DbSet<EquipeCombat> EquipeCombat { get; set; }
        public virtual DbSet<Paragraphe> Paragraphe { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Reponse> Reponse { get; set; }
        public virtual DbSet<Wookie> Wookie { get; set; }
    }
}
