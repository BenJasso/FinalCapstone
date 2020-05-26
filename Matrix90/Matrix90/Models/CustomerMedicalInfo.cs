using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerMedicalInfo
    {
        [Key]
        public int CustomerMedicalInfoId { get; set; }
        [ForeignKey("Customer")]
        public string IdentityUserId { get; set; }
        public string MedicalConditions { get; set; }
        public string Injuries { get; set; }
        public string PhysicalActivityLimitations { get; set; }
        public bool GastroIntestinalDiscomfort { get; set; }
        public string GastroInfo { get; set; }
        public string AdditionalInfo { get; set; }

    }
}
