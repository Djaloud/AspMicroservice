using MicroserviceEtudiant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceEtudiant.Repository
{
   public interface IEtudiantRepository
    {
        IEnumerable<Etudiant> GetEtudiants();
        Etudiant GetEtudiantByCne(int id_etudiant);
        void InsertEtudiant(Etudiant etudiant);
        void DeleteEtudiant(int id_etudiant);
        void UpdateEtudiant(Etudiant etudiant);
      
    }
}
