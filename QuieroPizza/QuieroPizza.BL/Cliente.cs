using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el telefono")]
        [MinLength(8, ErrorMessage = "El telefono debe ser de 8 digitos")]
        [MaxLength(8, ErrorMessage = "El telefono debe ser de 8 digitos")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la direccion")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
