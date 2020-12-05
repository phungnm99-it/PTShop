using PTShop.Application.Catalog.Products.Dtos;
using PTShop.Application.Catalog.Products.Dtos.Public;
using PTShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
