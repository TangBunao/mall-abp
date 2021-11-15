using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TangBunao.Mall.ProductCategories
{
    public class CreateUpdateProductCategoryDto
    {
        /// <summary>
        /// 上级分类的编号。0表示一级分类
        /// </summary>        
        [Required]
        public int ParentId { get; set; } = 0;

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        /// <summary>
        /// 分类级别：0表示一级，1表示2级
        /// </summary>
        [Required]
        public int Level { get; set; } = 0;

        /// <summary>
        /// 商品数量
        /// </summary>
        [Required]        
        public int ProductCount { get; set; } = 0;

        /// <summary>
        /// 商品单位
        /// </summary>
        [Required]
        [StringLength(64)]
        public string ProductUnit { get; set; }

        /// <summary>
        /// 是否显示在导航栏。0表示不显示，1表示显示
        /// </summary>
        [Required]        
        public int NavStatus { get; set; } = 1;

        /// <summary>
        /// 显示状态。0表示不显示，1表示显示
        /// </summary>
        [Required]        
        public int ShowStatus { get; set; } = 1;

        /// <summary>
        /// 排序
        /// </summary>
        [Required]        
        public int Sort { get; set; } = 0;

        /// <summary>
        /// 图标
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Icon { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Keywords { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Required]
        public string Description { get; set; }
    }
}
