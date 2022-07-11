using GeekShop.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace GeekShop.ProductAPI.Model
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }


    }
}
