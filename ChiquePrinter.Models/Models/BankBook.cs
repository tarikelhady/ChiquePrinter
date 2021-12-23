using ChiquePrinter.Domain.Models.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChiquePrinter.Domain.Models
{
    public class BankBook : ModelBase
    {
        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
        [Required]
        public int StartChiqueNo { get; set; }
        [Required]
        public int EndChiqueNo { get; set; }
        [Required]
        public Bank? Bank { get; set; }
        public Guid BankId { get; set; }
        public ICollection<Chique>? Chiques { get; set; }
    }
}
