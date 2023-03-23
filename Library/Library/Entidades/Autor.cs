using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogicaNegocio.Entidades
{
    public class Autor
    {
        #region Atributos
        public int Id { get; set; }
        //Por ahora ignoramos la advertencia de los strings nullables
        public string Nombre { get; set; }
        //Si un autor está vivo necesitamos que su fecha de defunción sea null
        //Por esa razón lo hacemos nullable.
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaDefuncion { get; set; } = null;
        #endregion
        #region Validaciones
        public void Validar()
        {
            throw new NotImplementedException("Falta implementar la validación de autor");
        }
        #endregion
    }
}
