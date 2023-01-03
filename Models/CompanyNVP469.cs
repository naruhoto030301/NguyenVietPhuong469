using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
#nullable disable
namespace NguyenVietPhuong469.Models
{
    public class CompanyNVP469
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
