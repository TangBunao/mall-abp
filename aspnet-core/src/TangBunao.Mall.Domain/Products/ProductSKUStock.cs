using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Products
{
    /// <summary>
    /// SKU(Stock Keeping Unit)是指库存量单位，SPU(Standard Product Unit)是指标准产品单位。举个例子：iphone xs是一个SPU，而iphone xs 公开版 64G 银色是一个SKU。
    /// </summary>
    public class ProductSKUStock : FullAuditedEntity<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// sku编码
        /// </summary>
        public string SKUCode { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 库存预警
        /// </summary>
        public int LowStock { get; set; }

        /// <summary>
        /// 规格属性1
        /// </summary>
        public string Sp1 { get; set; }

        /// <summary>
        /// 规格属性2
        /// </summary>
        public string Sp2 { get; set; }

        /// <summary>
        /// 规格属性3
        /// </summary>
        public string Sp3 { get; set; }

        /// <summary>
        /// 展示图片
        /// </summary>
        public string Pic { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sale { get; set; }

        /// <summary>
        /// 单品促销价格
        /// </summary>
        public decimal PromotionPrice { get; set; }

        /// <summary>
        /// 锁定库存
        /// </summary>
        public int LockStock { get; set; }
    }
}
