using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceEtudiant.Model
{
    public class Etudiant
    {
        [Key]
        public int id_etudiant { get; set; }
        public String cne { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
    }
}
