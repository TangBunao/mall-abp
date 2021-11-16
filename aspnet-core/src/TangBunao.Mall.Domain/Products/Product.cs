using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Products
{
    /// <summary>
    /// 商品信息主要包括四部分：商品的基本信息、商品的促销信息、商品的属性信息、商品的关联，商品表是整个商品的基本信息部分。
    /// </summary>
    public class Product : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 品牌Id
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// 商品分类Id
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// 运费模板Id
        /// </summary>
        public int FeightTemplateId { get; set; }

        /// <summary>
        /// 商品属性分类Id
        /// </summary>
        public int ProductAttributeCategoryId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Pic { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        public string ProductSN { get; set; }

        /// <summary>
        /// 删除状态。0表示未删除，1表示已删除
        /// </summary>
        public int DeleteStatus { get; set; }

        /// <summary>
        /// 上架状态。0表示下架，1表示上架
        /// </summary>
        public int PublishStatus { get; set; }

        /// <summary>
        /// 新品状态。0表示不是新品，1表示新品
        /// </summary>
        public int NewStatus { get; set; }

        /// <summary>
        /// 推荐状态。0表示不推荐，1表示推荐
        /// </summary>
        public int RecommandStatus { get; set; }

        /// <summary>
        /// 审核状态。0表示未审核，1表示审核通过
        /// </summary>
        public int VerifyStatus { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sale { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 促销价格
        /// </summary>
        public decimal PromotionPrice { get; set; }

        /// <summary>
        /// 赠送的成长值
        /// </summary>
        public int GiftGrowth { get; set; }

        /// <summary>
        /// 赠送的积分
        /// </summary>
        public int GiftPoint { get; set; }

        /// <summary>
        /// 限制使用的积分数
        /// </summary>
        public int UsePointLimit { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string SubTitle { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 库存预警值
        /// </summary>
        public int LowStock { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 商品重量，默认为克
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 是否为预告商品。0表示不是，1表示是
        /// </summary>
        public int PreviewStatus { get; set; }

        /// <summary>
        /// 以逗号分割的产品服务：1表示无忧退货，2表示快速退款，3表示包邮
        /// </summary>
        public string ServiceIds { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWords { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 画图图片，连产品图片限制为5张，以逗号分割
        /// </summary>
        public string AlbumPics { get; set; }

        /// <summary>
        /// 详情标题
        /// </summary>
        public string DetailTitle { get; set; }

        /// <summary>
        /// 详情描述
        /// </summary>
        public string DetailDesc { get; set; }

        /// <summary>
        /// 详情网页内容
        /// </summary>
        public string DetailHtml { get; set; }

        /// <summary>
        /// 移动端网页详情
        /// </summary>
        public string DetailMobileHtml { get; set; }

        /// <summary>
        /// 促销开始时间
        /// </summary>
        public DateTime PromotionStartTime { get; set; }

        /// <summary>
        /// 促销结束时间
        /// </summary>
        public DateTime PromotionEndTime { get; set; }

        /// <summary>
        /// 促销限购数量
        /// </summary>
        public int PromotionPerLimit { get; set; }

        /// <summary>
        /// 促销类型。0表示没有促销使用原价，1表示使用促销价，2表示使用会员价，3表示使用阶梯价格，4表示使用满减价格，5表示限时购
        /// </summary>
        public int PromotionType { get; set; }

        /// <summary>
        /// 产品分类名称
        /// </summary>
        public string ProductCategoryName { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }
    }
}
