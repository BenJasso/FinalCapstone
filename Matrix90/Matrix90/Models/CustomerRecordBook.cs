using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerRecordBook
    {
        [Key]
        public int CustomerRecordBookId { get; set; }
        [ForeignKey("Customer")]
        
        public int CustomerId { get; set; }
        [NotMapped]
        public List<int> Weights { get; set; }
        [NotMapped]
        public List<int> Necks { get; set; }
        [NotMapped]
        public List<int> Shoulders { get; set; }
        [NotMapped]
        public List<int> Chests { get; set; }
        [NotMapped]
        public List<int> Waists { get; set; }
        [NotMapped]

        public List<int> Hips { get; set; }
        [NotMapped]
        public List<int> Thighs { get; set; }
        [NotMapped]
        public List<int> Calves { get; set; }
        [NotMapped]
        public List<int> Arms { get; set; }
    }
}
