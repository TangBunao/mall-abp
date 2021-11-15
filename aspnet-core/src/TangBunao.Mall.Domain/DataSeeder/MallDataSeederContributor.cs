using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangBunao.Mall.ProductCategories;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace TangBunao.Mall.DataSeeder
{
    public class MallDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<ProductCategory, int> _productCategoryRepo;

        public MallDataSeederContributor(IRepository<ProductCategory, int> productCategoryRepo)
        {
            _productCategoryRepo = productCategoryRepo;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productCategoryRepo.GetCountAsync() <= 0)
            {

                await _productCategoryRepo.InsertAsync(new ProductCategory
                {
                    Name = "家用电器",
                    ProductUnit = "件",
                    NavStatus = 1,
                    ShowStatus = 1,
                    Sort = 0,
                    Icon = "",
                    Keywords = "家用，电器，空调，冰箱，洗衣机",
                    Description = "家用电器类商品"
                }, autoSave: true);


                await _productCategoryRepo.InsertAsync(new ProductCategory
                {
                    Name = "电脑办公",
                    ProductUnit = "件",
                    NavStatus = 1,
                    ShowStatus = 1,
                    Sort = 1,
                    Icon = "",
                    Keywords = "电脑办公主机",
                    Description = "电脑办公类商品"
                }, autoSave: true);
            }
        }
    }
}
