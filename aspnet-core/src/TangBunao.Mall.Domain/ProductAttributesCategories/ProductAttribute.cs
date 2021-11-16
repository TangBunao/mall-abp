using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductAttributesCategories
{
    /// <summary>
    /// 商品属性表
    /// </summary>
    public class ProductAttribute : FullAuditedEntity<int>
    {
        /// <summary>
        /// 商品属性分类Id
        /// </summary>
        public int ProductAttributeCategoryId { get; set; }

        /// <summary>
        /// 商品属性名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 属性选择类型。0表示唯一，1表示单选，2表示多选。对应属性和参数意义不同
        /// </summary>
        public int SelectType { get; set; }

        /// <summary>
        /// 属性录入方式。0表示手工录入，1表示从列表中选取
        /// </summary>
        public int InputType { get; set; }

        /// <summary>
        /// 可选值列表，以逗号隔开
        /// </summary>
        public string InputList { get; set; }

        /// <summary>
        /// 排序字段，最高的可以单独上传图片
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 分类筛选样式。0表示普通，1表示颜色
        /// </summary>
        public int FilterType { get; set; }

        /// <summary>
        /// 检索类型。0表示不需要进行检索，1表示关键字检索，2表示范围检索
        /// </summary>
        public int SearchType { get; set; }

        /// <summary>
        /// 相同属性产品是否关联。0表示不关联，1表示关联
        /// </summary>
        public int RelatedStatus { get; set; }

        /// <summary>
        /// 是否支持手动新增。0表示不支持，1表示支持
        /// </summary>
        public int HandAddStatus { get; set; }

        /// <summary>
        /// 属性的类型。0表示规格，1表示参数
        /// </summary>
        public int Type { get; set; }
    }
}
