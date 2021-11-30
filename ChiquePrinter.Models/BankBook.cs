using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChiquePrinter.Models
{
    public class BankBook : ModelBase
    {
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        public int StartChiqueNo { get; set; }
        [Required]
        public int EndChiqueNo { get; set; }
        [Required]
        public Bank Bank { get; set; }
        public ICollection<Chique> Chiques { get; set; }
    }
}
