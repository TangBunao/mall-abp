using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TangBunao.Mall.ProductCategories
{
    public interface IProductCategoryService
        : ICrudAppService<ProductCategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateProductCategoryDto>
    {

    }
}
