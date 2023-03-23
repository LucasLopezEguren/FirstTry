using Library.BusinessLogic.Entidades;
using Library.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AccessData.InMemory
{
    public class MemorySubjectRepository : ISubjectRepository
    {
        public List<Subject> subjects = new List<Subject> {
            new Subject(0, "Fantasía", "Género fantasía"),
            new Subject(1, "Terror", "Género terror"),
            new Subject(2, "Ciencia ficción", "Género ciencia ficción"),
        };

        public void Add(Subject subject)
        {
            subjects.Add(subject);
        }

        public int Count()
        {
            return subjects.Count();
        }

        public void Delete(int id)
        {
            subjects.RemoveAt(id);
        }

        public IEnumerable<Subject> GetAll()
        {
            return subjects;
        }

        public Subject GetById(int id)
        {
            return subjects[id];
        }
    }
}
