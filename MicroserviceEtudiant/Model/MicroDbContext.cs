using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceEtudiant.Model
{
    public class MicroDbContext:DbContext
    {
        public MicroDbContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Etudiant> etudiants { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etudiant>().HasData(
                new Etudiant
                {
                    id_etudiant=1,
                    cne = "CNE01",
                    Nom = "Djaloud",
                    Prenom = "Louariga",
                },
                new Etudiant
                {
                    id_etudiant = 2,
                    cne = "CNE02",
                    Nom = "Nokri",
                    Prenom = "MIRI",
                },
                new Etudiant
                {
                    id_etudiant = 3,
                    cne = "CNE03",
                    Nom = "Yassine",
                    Prenom = "Hafid",
                }
            );
        }
    }
    
}
