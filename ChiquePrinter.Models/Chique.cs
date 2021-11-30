using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Models
{
    public class Chique : ModelBase
    {
        [Required]
        public new string No { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        public ChiqueAddress Address { get; set; }
        [Required]
        public Payee Payee { get; set; }
        [Required]
        public BankBook BankBook { get; set; }
        [Required]
        public Bank Bank { get; set; }
        public string Comment { get; set; }   // يصرف للمستفيد الاول
        [Required]
        public DateTime WrittenDate { get; set; }   // تاريخ التحرير
        public DateTime MatuityDate { get; set; }   // تاريخ الاستحقاق
        [Required]
        public Decimal Amount { get; set; }
        [Required]
        public Currency Currency { get; set; }
        public ICollection<UserLog> UserLogs { get; set; }



    }
}
