using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Coupons
{
    /// <summary>
    /// 优惠券和商品分类关系表，用于存储优惠券与商品分类的关系，当优惠券的使用类型为指定分类时，优惠券与商品分类需要建立关系
    /// </summary>
    public class CouponProductCategoryRelation:FullAuditedEntity<int>
    {
        public int CouponId { get; set; }

        public int ProductCategoryId { get; set; }

        public int ProductCategoryName { get; set; }

        public string ParentCategoryName { get; set; }
        
    }
}
