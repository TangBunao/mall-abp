using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Coupons
{
    /// <summary>
    /// 优惠券和商品关系表，用于存储优惠券与商品的关系，当优惠券的使用类型为指定商品是，优惠券与商品需要建立关系
    /// </summary>
    public class CouponProductRelation : FullAuditedEntity<int>
    {
        /// <summary>
        /// 优惠券Id
        /// </summary>
        public int CouponId { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string ProductSN { get; set; }
    }
}
