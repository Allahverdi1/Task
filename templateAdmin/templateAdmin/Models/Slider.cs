using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace templateAdmin.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public int DiscountPercent { get; set; }
        [Required(ErrorMessage="Bura bosh ola bilmez"), MinLength(10)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
