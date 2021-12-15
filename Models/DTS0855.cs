using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuThaiSon855.Models
{
    [Table("DTS0855s")]
    public class DTS0855
    {
        [Key]
         [StringLength(20), Display(Name= " Dư Thái Sơn ID")]
        public string DTSID { get; set; }
        [StringLength(50), Display(Name= "Tên Dư Thái Sơn ")]
        public string DTSName { get; set; }
        public string DTSGender { get; set; }
              
    }
}