using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TangBunao.Mall.ProductBrands
{
    public class BrandDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 品牌首字母
        /// </summary>
        public string FirstLetter { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 是否为品牌制造商。0表示不是，1表示是
        /// </summary>
        public int FactoryStatus { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public int ShowStatus { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// 产品评论数量
        /// </summary>
        public int ProductCommentCount { get; set; }

        /// <summary>
        /// 品牌LOGO
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 专区大图
        /// </summary>
        public string BigPic { get; set; }

        /// <summary>
        /// 品牌故事
        /// </summary>
        public string BrandStory { get; set; }
    }
}
