using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Models
{
    public class UserLog
    {
        public Guid Id { get; set; }
        public Chique Chique { get; set; }
        public Status Status { get; set; }
        public User User { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
