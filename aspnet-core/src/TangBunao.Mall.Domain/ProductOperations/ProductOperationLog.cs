using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductOperations
{
    public class ProductOperationLog : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 改变前价格
        /// </summary>
        public decimal PriceOld { get; set; }

        /// <summary>
        /// 改变后价格
        /// </summary>
        public decimal PriceNew { get; set; }

        /// <summary>
        /// 改变前优惠价
        /// </summary>
        public decimal SalePriceOld { get; set; }

        /// <summary>
        /// 改变后优惠价
        /// </summary>
        public decimal SalePriceNew { get; set; }

        /// <summary>
        /// 改变前积分
        /// </summary>
        public int GiftPointOld { get; set; }

        /// <summary>
        /// 改变后积分
        /// </summary>
        public int GiftPointNew { get; set; }

        /// <summary>
        /// 改变前积分使用限制
        /// </summary>
        public int UsePointLimitOld { get; set; }

        /// <summary>
        /// 改变后积分使用限制
        /// </summary>
        public int UsePointLimitNew { get; set; }

    }
}
