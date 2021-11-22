using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.HomeBrands
{
    /// <summary>
    /// 首页品牌推荐表
    /// </summary>
    public class HoneBrand : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 品牌Id
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }

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
