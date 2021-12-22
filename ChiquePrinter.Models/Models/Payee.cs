using ChiquePrinter.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Models
{
    public class Payee : ModelBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AuthorzedPerson { get; set; }
        public string AuthorzedPersonPhone { get; set; }
        public string AuthorzedPersonMobile { get; set; }
        public string AuthorzedPersonEmail { get; set; }
        public string AuthorzedPersonJob { get; set; }
        public string authorizationImage { get; set; }

    }
}
