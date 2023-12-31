﻿using FlexCoreService.ProductCtrl.Models.Dtos;

namespace FlexCoreService.ProductCtrl.Interface
{
    public interface IProductRepository
    {
        IEnumerable<ProductCardDto> SearchProducts();

        IEnumerable<ProductCardDto> SearchSalesProducts(int salesId);
    }
}
