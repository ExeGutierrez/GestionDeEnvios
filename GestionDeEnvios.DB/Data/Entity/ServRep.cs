using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class ServRep : EntityBase
    {
        public int ServRepID { get; set; }
        [Required(ErrorMessage = "El ID del Reparto es obligatorio")]
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "El ID del Cliente es obligatorio")]
        public DateTime FechaSolicitud { get; set; }
        [Required(ErrorMessage = "La fecha de Generacion es obligatorio")]
        [Range(typeof(DateTime), "01/01/2000", "12/31/2024",
      ErrorMessage = "La fecha debe estar entre {1} y {2}")]
        public string Estado { get; set; }
        public string Efectividad { get; set; }
        public string Detalles { get; set; }
        public Cliente Cliente { get; set; }
        public List<Cliente> Clientes { get; set; }

        public int SocioID {get; set;}
        public Socio Socio { get; set; }
        public List<Socio>Socios { get; set; }
    }
}
