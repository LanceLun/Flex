using FlexCoreService.ProductCtrl.Models.Dtos;
using FlexCoreService.ProductCtrl.Models.VM;

namespace FlexCoreService.ProductCtrl.Exts
{
    public static class CategoryExts
    {
        public static CategoryVM ToVM(this CategoryDto dto)
        {
            return new CategoryVM
            {
                ProductCategoryName = dto.ProductCategoryName,
            };
        }
    }
}
