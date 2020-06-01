using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class Notification
    {
        [Key]
        public int notificationId { get; set; }

        public string notificationInfo { get; set; }
        [ForeignKey("NetUsers")]
        public string Id { get; set; }

        public string controllerAction { get; set; }
    }
}
