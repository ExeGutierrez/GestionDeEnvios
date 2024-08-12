using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class Presupuesto : EntityBase
    {
        public int PresupuestoID { get; set; }
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "El ID del Cliente es obligatorio")]
        public string Detalles { get; set; }
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "El Costo es obligatorio")]
        public DateTime FechaSolicitud { get; set; }
        [Required(ErrorMessage = "La fecha de solicitud es obligatorio")]
        [Range(typeof(DateTime), "01/01/2000", "12/31/2024",
      ErrorMessage = "La fecha debe estar entre {1} y {2}")]
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
        public List<Cliente>Clientes {  get; set; }

    }
}
