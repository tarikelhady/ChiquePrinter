using ChiquePrinter.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChiquePrinter.Domain.Models
{
    public class Bank : ModelBase
    {
        public Bank(BankScema bankScema, ICollection<BankBook> bankBook)
        {
            BankScema = bankScema;
            BankBooks = bankBook;
        }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public BankScema BankScema { get; set; }

        public ICollection<BankBook> BankBooks { get; set; }
        public int BookLength { get; set; }
    }
}
