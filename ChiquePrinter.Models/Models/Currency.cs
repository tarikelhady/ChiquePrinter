using ChiquePrinter.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Models
{
   public class Currency : ModelBase
    {
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
