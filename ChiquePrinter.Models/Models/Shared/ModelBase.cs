using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Models.Shared
{
   public class ModelBase
    {
        public Guid Id { get; set; }
        [Required]
        public int No { get; set; }
        public User CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public User ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
