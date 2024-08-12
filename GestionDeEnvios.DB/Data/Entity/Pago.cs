using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data.Entity
{
    public class Pago : EntityBase
    {
        public int PagoID { get; set; }
        [Required(ErrorMessage = "El ID del pago es obligatorio")]
        public int ServRep { get; set; }
        public Decimal Monto { get; set; }
        [Required(ErrorMessage = "El monto es obligatorio")]
        public DateTime FechaPago { get; set; }
        [Required(ErrorMessage = "La fecha de pago es obligatorio")]
        [Range(typeof(DateTime), "01/01/2000", "12/31/2024",
            ErrorMessage = "La fecha debe estar entre {1} y {2}")]
        public ServRep ServReps { get; set; }
        List<ServRep> Servers { get; set; }

    }
}
