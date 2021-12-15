using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuThaiSon855.Models
{
    [Table("Company_DTS855s")]
    public class Company_DTS855
    {
        [Key]
         [StringLength(20), Display(Name= "Công ty ID")]
        public string CompanyID { get; set; }
        [StringLength(50), Display(Name= "tên Công Ty")]
        public string CompanyName { get; set; }
              
    }
}