using MicroserviceEtudiant.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceEtudiant.Repository
{
    public class EtudiantRepository : IEtudiantRepository
    {
        private readonly MicroDbContext _dbContext;

        public EtudiantRepository(MicroDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public void DeleteEtudiant(int id_etudiant)
        {
            var etudiant = _dbContext.etudiants.Find(id_etudiant);
            _dbContext.etudiants.Remove(etudiant);
            _dbContext.SaveChanges();
        }

        public Etudiant GetEtudiantByCne(int EtudiantCne)
        {
            return _dbContext.etudiants.Find(EtudiantCne);
        }

        public IEnumerable<Etudiant> GetEtudiants()
        {
            return _dbContext.etudiants.ToList();
        }

        public void InsertEtudiant(Etudiant etudiant)
        {
            _dbContext.etudiants.Add(etudiant);
            _dbContext.SaveChanges();
        }

        

        public void UpdateEtudiant(Etudiant etudiant)
        {
            _dbContext.Entry(etudiant).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
