﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Models
{
    public class User : ModelBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<UserLog> UserLogs { get; set; }

    }
}
