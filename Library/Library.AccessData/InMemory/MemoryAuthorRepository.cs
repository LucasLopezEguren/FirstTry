using Library.BusinessLogic.Entidades;
using Library.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AccessData.InMemory
{
    public class MemoryAuthorRepository : IAuthorRepository
    {
        public List<Author> authors = new List<Author> {
            new Author(0, "Stephen King", "EE UU"),
            new Author(1, "Alfonsina Stormi", "Argentina"),
            new Author(2, "Horacio Quiroga", "Uruguay"),
        };

        public void Add(Author author)
        {
            authors.Add(author);
        }

        public int Count()
        {
            return authors.Count();
        }

        public void Delete(int id)
        {
            authors.RemoveAt(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return authors;
        }

        public Author GetById(int id)
        {
            return authors[id];
        }
    }
}
