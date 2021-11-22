using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.HomeNewProducts
{
    /// <summary>
    /// 首页新品推荐商品表，用于管理首页显示的新鲜好物信息
    /// </summary>
    public class HomeNewProduct : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 推荐状态。0表示不推荐，1表示推荐
        /// </summary>
        public int RecommendStatus { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
