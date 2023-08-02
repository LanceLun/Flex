using FlexCoreService.Models.EFModels;
using FlexCoreService.ProductCtrl.Interface;
using FlexCoreService.ProductCtrl.Models.Dtos;

namespace FlexCoreService.ProductCtrl.Service
{
    public class ProductService
    {
        private IProductRepository _repo;
        private AppDbContext _db;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
            _db = new AppDbContext();
        }

        public IEnumerable<ProductCardDto> SearchProducts()
        {
            var products = _repo.SearchProducts();
            return products;
        }

        public IEnumerable<ProductCardDto> SearchSalesProducts(int salesId)
        {
            var products = _repo.SearchSalesProducts(salesId);
            return products;
        }
    }
}
