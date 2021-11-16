using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TangBunao.Mall.ProductBrands
{
    public interface IBrandService
        : ICrudAppService<BrandDto, int, PagedAndSortedResultRequestDto, CreateUpdateBrandDto>
    {

    }
}
