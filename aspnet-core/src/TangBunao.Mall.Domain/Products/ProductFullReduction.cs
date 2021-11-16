using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Products
{
    /// <summary>
    /// 商品优惠相关表，购买同商品满足一定金额后，可以减免一定金额。如：买满1000减100元。
    /// </summary>
    public class ProductFullReduction:FullAuditedEntity<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 商品满足金额
        /// </summary>
        public decimal FullPrice { get; set; }

        /// <summary>
        /// 商品减少金额
        /// </summary>
        public decimal ReducePrice { get; set; }
    }
}
