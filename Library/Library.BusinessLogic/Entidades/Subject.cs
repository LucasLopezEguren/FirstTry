using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor Lucas Lopez
// Diego Fagundez
namespace Library.BusinessLogic.Entidades
{
    public class Subject
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set;}

        public Subject() { }
        public Subject(int id) {
            this.Id = id;
        }
        public Subject(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public bool isValid()
        {
            throw new Exception("Error al crear el tema.");
            return true;
        }
    }
}
