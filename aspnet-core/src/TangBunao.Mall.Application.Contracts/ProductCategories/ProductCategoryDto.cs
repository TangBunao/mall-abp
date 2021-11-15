using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TangBunao.Mall.ProductCategories
{
    public class ProductCategoryDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 上级分类的编号。0表示一级分类
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分类级别：0表示一级，1表示2级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        public string ProductUnit { get; set; }

        /// <summary>
        /// 是否显示在导航栏。0表示不显示，1表示显示
        /// </summary>
        public int NavStatus { get; set; }

        /// <summary>
        /// 显示状态。0表示不显示，1表示显示
        /// </summary>
        public int ShowStatus { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
