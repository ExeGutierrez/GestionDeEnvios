using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class Socio : EntityBase
    {
        public int SocioID { get; set; }
        [Required(ErrorMessage = "El ID del Socio es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre del Socio es obligatorio")]
        public string Contacto { get; set; }
        [Required(ErrorMessage = "El contacto del Socio es obligatorio")]
        public string Disponibilidad { get; set; }
    }
}
