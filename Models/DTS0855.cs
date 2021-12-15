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
        [StringLength(50), Display(Name= "Tên Dư Thái Sơn "),Required]
        public string DTSName { get; set; }
         [ Display(Name= " Dư Thái Sơn Giới Tính "),Required]
        public string DTSGender { get; set; }
              
    }
}