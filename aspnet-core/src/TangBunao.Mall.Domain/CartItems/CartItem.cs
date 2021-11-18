using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.CartItems
{
    /// <summary>
    /// 存储购物车中每个商品信息，可用于计算商品优惠金额
    /// </summary>
    public class CartItem : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 商品SKU的Id
        /// </summary>
        public int ProductSKUId { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 添加到购物车的价格
        /// </summary>
        public decimal Price { get; set; }

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
        /// 商品主图
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
        /// 商品副标题
        /// </summary>
        public string ProductSubTitle { get; set; }

        /// <summary>
        /// 商品SKU条码
        /// </summary>
        public string ProductSKUCode { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string MemberNickname { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// 商品分类Id
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// 商品销售属性，[{"key":"颜色","value":"颜色"},{"key":"容量","value":"4G"}]
        /// </summary>
        public string ProductAttr { get; set; }
    }
}
