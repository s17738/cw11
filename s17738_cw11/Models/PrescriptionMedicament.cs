using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s17738_cw11.Models
{
    public class PrescriptionMedicament
    {
        public int IdMedicament { get; set; }

        public int IdPrescription { get; set; }

        public int? Dose { get; set; }

        public string Details { get; set; }

    }
}
