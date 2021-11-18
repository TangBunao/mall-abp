using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Orders
{
    /// <summary>
    /// 订单中包含的商品信息，一个订单中有多个商品的信息
    /// </summary>
    public class OrderItem : FullAuditedEntity<int>
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderSN { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        public string ProductPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public string ProductBrand { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string ProductSN { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int ProductQuantity { get; set; }

        /// <summary>
        /// 商品SKU编号
        /// </summary>
        public int ProductSKUId { get; set; }

        /// <summary>
        /// 商品SKU条码
        /// </summary>
        public string ProductSKUCode { get; set; }

        /// <summary>
        /// 商品分类Id
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// 商品销售属性1
        /// </summary>
        public string Sp1 { get; set; }

        /// <summary>
        /// 商品销售属性2
        /// </summary>
        public string Sp2 { get; set; }

        /// <summary>
        /// 商品销售属性3
        /// </summary>
        public string Sp3 { get; set; }

        /// <summary>
        /// 商品促销名称
        /// </summary>
        public string PromotionName { get; set; }

        /// <summary>
        /// 商品促销分解金额
        /// </summary>
        public decimal PromotionAmount { get; set; }

        /// <summary>
        /// 优惠券优惠分解金额
        /// </summary>
        public decimal CouponAmount { get; set; }

        /// <summary>
        /// 积分优惠分解金额
        /// </summary>
        public decimal IntegrationAmount { get; set; }

        /// <summary>
        /// 商品经过优惠后的分解金额
        /// </summary>
        public decimal RealAmount { get; set; }

        /// <summary>
        /// 商品赠送的积分
        /// </summary>
        public int GiftIntegration { get; set; }

        /// <summary>
        /// 商品赠送的成长值
        /// </summary>
        public int GiftGrowth { get; set; }

        /// <summary>
        /// 商品销售属性，[{"key":"颜色","value":"颜色"},{"key":"容量","value":"4G"}]
        /// </summary>
        public string ProductAttr { get; set; }
    }
}
