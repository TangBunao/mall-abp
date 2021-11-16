using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TangBunao.Mall.ProductBrands
{
    public class CreateUpdateBrandDto
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 品牌首字母
        /// </summary>
        [Required]
        public string FirstLetter { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Required]
        public int Sort { get; set; } = 1;

        /// <summary>
        /// 是否为品牌制造商。0表示不是，1表示是
        /// </summary>
        [Required]
        public int FactoryStatus { get; set; } = 0;

        /// <summary>
        /// 是否显示
        /// </summary>
        [Required]
        public int ShowStatus { get; set; } = 1;

        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductCount { get; set; } = 0;

        /// <summary>
        /// 产品评论数量
        /// </summary>
        public int ProductCommentCount { get; set; } = 0;

        /// <summary>
        /// 品牌LOGO
        /// </summary>
        [Required]
        public string Logo { get; set; }

        /// <summary>
        /// 专区大图
        /// </summary>
        [Required]
        public string BigPic { get; set; }

        /// <summary>
        /// 品牌故事
        /// </summary>
        [Required]
        public string BrandStory { get; set; }
    }
}
