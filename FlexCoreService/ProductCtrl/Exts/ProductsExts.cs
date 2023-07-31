using FlexCoreService.ProductCtrl.Models.Dtos;
using FlexCoreService.ProductCtrl.Models.VM;

namespace FlexCoreService.ProductCtrl.Exts
{
    public static class ProductsExts
    {
        public static ProductCardVM ToCardVM(this ProductCardDto dto)
        {
            return new ProductCardVM
            {
                ProductId = dto.ProductId,
                ProductName = dto.ProductName,
                UnitPrice = dto.UnitPrice,
                SalesPrice = dto.SalesPrice,
                FirstImgPath = dto.FirstImgPath,
            };
        }
    }
}
