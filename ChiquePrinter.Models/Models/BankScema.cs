using ChiquePrinter.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Models
{
    public class BankScema : ModelBase
    {
        [Required]
        public string Discription { get; set; }
        [Required]
        public Bank Bank { get; set; }
        public Guid BankId { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public string DateFormat { get; set; }
        [Required]
        public string FontName { get; set; }
        [Required]
        public bool FontIsBold { get; set; }
        [Required]
        public bool FontIsItalic { get; set; }
        [Required]
        public int FontSize { get; set; }
        [Required]
        public bool AlignRight{ get; set; }
        [Required]
        public int PaddingVertical { get; set; }
        [Required]
        public bool AlignTop { get; set; }
        [Required]
        public int PaddingHorizontal { get; set; }
        [Required]
        public int Xamount1 { get; set; }
        [Required]
        public int Xamount2 { get; set; }
        [Required]
        public int Yamount1 { get; set; }
        [Required]
        public int Yamount2 { get; set; }
        [Required]
        public int XtextAmount1 { get; set; }
        [Required]
        public int XtextAmount2 { get; set; }
        [Required]
        public int YtextAmount1 { get; set; }
        [Required]
        public int YtextAmount2 { get; set; }
        [Required]
        public int Xpayee1 { get; set; }
        [Required]
        public int Xpayee2 { get; set; }
        [Required]
        public int Ypayee1 { get; set; }
        [Required]
        public int Ypayee2 { get; set; }
        [Required]
        public int Xdate1 { get; set; }
        [Required]
        public int Xdate2 { get; set; }
        [Required]
        public int Ydate1 { get; set; }
        [Required]
        public int Ydate2 { get; set; }
        [Required]
        public int Xaddress1 { get; set; }
        [Required]
        public int Xaddress2 { get; set; }
        [Required]
        public int Yaddress1 { get; set; }
        [Required]
        public int Yaddress2 { get; set; }
        [Required]
        public int Xdiscription1 { get; set; }
        [Required]
        public int Xdiscription2 { get; set; }
        [Required]
        public int Ydiscription1 { get; set; }
        [Required]
        public int Ydiscription2 { get; set; }
        [Required]
        public int Xcomment1 { get; set; }
        [Required]
        public int Xcomment2 { get; set; }
        [Required]
        public int Ycomment1 { get; set; }
        [Required]
        public int Ycomment2 { get; set; }
    }
    public  enum Point
    {
        x,
        y
    }
}
