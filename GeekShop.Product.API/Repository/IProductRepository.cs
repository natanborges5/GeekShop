using GeekShop.ProductAPI.Data.ValueObjects;

namespace GeekShop.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVo>> FindAll();
        Task<ProductVo> FindById(long id);
        Task<ProductVo> Create(ProductVo productVo);
        Task<ProductVo> Update(ProductVo productVo);
        Task<bool> Delete(long id);

    }
}
