using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductComments
{
    /// <summary>
    /// 商品评价表
    /// </summary>
    public class ProductComment : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string MemberNickName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 评价星数。0-5
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// 评价用户的IP
        /// </summary>
        public string MemberIP { get; set; }

        /// <summary>
        /// 是否显示。0表示不显示，1表示显示
        /// </summary>
        public int ShowStatus { get; set; }

        /// <summary>
        /// 购买时商品的属性
        /// </summary>
        public string ProductAttribute { get; set; }

        /// <summary>
        /// 收藏数
        /// </summary>
        public int CollectCount { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        public int ReadCount { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 上传图片的地址，以逗号隔开
        /// </summary>
        public string Pics { get; set; }

        /// <summary>
        /// 评论用户的头像
        /// </summary>
        public string MemberIcon { get; set; }

        /// <summary>
        /// 回复数
        /// </summary>
        public int ReplayCount { get; set; }
    }
}
