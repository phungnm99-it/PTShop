using PTShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CatagoryIds { get; set; }
    }
}
