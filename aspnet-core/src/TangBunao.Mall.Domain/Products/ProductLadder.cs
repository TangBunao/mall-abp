using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Products
{
    /// <summary>
    /// 商品优惠相关表，购买同商品满足一定数量后，可以使用打折价格进行购买。如：买两件商品可以打八折。
    /// </summary>
    public class ProductLadder:FullAuditedEntity<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 满足的商品数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public decimal DisCount { get; set; }

        /// <summary>
        /// 折后价格
        /// </summary>
        public decimal Price { get; set; }
    }
}
