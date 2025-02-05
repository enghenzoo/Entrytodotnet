using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]   
        public Company Company { get; set; }
    }
}
