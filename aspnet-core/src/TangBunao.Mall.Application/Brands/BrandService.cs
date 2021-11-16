using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TangBunao.Mall.ProductBrands
{
    public class BrandService
        : CrudAppService<ProductBrand, BrandDto, int, PagedAndSortedResultRequestDto, CreateUpdateBrandDto>
    {
        public BrandService(IRepository<ProductBrand, int> repository)
            : base(repository)
        {

        }
    }
}
