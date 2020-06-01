using Microsoft.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class TipOfWeekViewModel
    {
        public List<TipOfWeek> tips { get; set; }
        public string subject { get; set; }
    }
}
