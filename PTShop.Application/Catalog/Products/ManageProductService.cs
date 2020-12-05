using PTShop.Application.Catalog.Products.Dtos;
using PTShop.Application.Catalog.Products.Dtos.Manage;
using PTShop.Application.Dtos;
using PTShop.Data.EF;
using PTShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly PTShopDbContext _context;
        public ManageProductService(PTShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var dienThoai = new DienThoai()
            {
                Gia = request.Gia
            };
            _context.DienThoais.Add(dienThoai);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
