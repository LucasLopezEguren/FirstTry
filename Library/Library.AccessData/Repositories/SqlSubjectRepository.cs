using Library.BusinessLogic.Entidades;
using Library.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AccessData.Repositories
{
    public class SqlSubjectRepository : ISubjectRepository
    {
        private LibraryContext _context = new LibraryContext();
        public void Add(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Subjects.ToList().Count;
        }

        public void Delete(int id)
        {
            Subject subject = new Subject(id);
            _context.Subjects.Remove(subject);
            _context.SaveChanges();
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects;
        }

        public Subject GetById(int id)
        {
            return _context.Subjects.ToList()[id-1];
        }
    }
}
