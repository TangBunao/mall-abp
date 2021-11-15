using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TangBunao.Mall.ProductCategories
{
    public class ProductCategoryService
        : CrudAppService<
            ProductCategory, //The Book entity
            ProductCategoryDto, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateProductCategoryDto>
        , IProductCategoryService
    {

        public ProductCategoryService(IRepository<ProductCategory, int> repository)
            : base(repository)
        {

        }
    }
}
