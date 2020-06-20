using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s17738_cw11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public int IdPatient { get; set; }
        
        public int IdDoctor { get; set; }

        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }
    }
}
