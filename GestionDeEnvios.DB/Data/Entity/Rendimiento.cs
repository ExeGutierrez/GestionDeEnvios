using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class Rendimiento : EntityBase
    {
        public int InformeID { get; set; }
        [Required(ErrorMessage = "El ID es obligatorio")]

        public DateTime FechaGeneracion { get; set; }
        [Required(ErrorMessage = "La fecha de Generacion es obligatorio")]
        [Range(typeof(DateTime), "01/01/2000", "12/31/2024",
      ErrorMessage = "La fecha debe estar entre {1} y {2}")]
        public string Descripcion { get; set; }
        public string Efectividad { get; set; }

        public int ServRepID { get; set; }
        public ServRep ServRep { get; set; }
        public List<ServRep> ServReps { get; set; }
    }
}
