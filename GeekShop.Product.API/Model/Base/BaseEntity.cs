using System.ComponentModel.DataAnnotations;

namespace GeekShop.ProductAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
