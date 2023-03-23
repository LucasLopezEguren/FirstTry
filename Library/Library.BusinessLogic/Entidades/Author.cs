using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic.Entidades
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string country { get; set; }

        public DateTime? birthDate { get; set; }
        public DateTime? deathDate { get; set; } = null;
        public Author() { }
        public Author(int id, string name, string country)
        {
            Id = id;
            this.name = name;
            this.country = country;
        }

        public void Valid()
        {
            throw new NotImplementedException("Falta implementar la validación de autor");
        }
    }
}
