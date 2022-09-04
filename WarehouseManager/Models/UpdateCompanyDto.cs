using System.ComponentModel.DataAnnotations;

namespace WarehouseManager.Models
{
    public class UpdateCompanyDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
