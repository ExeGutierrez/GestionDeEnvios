using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class Cliente : EntityBase
    {
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "El ID del cliente es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
        public string Tipo { get; set; }

        public string Contacto { get; set; }

    }
}