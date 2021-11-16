using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductComments
{
    /// <summary>
    /// 商品评价回复表
    /// </summary>
    public class ProductCommentReplay : FullAuditedEntity<int>
    {
        /// <summary>
        /// 商品评论Id
        /// </summary>
        public int ProductCommentId { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string MemberNickName { get; set; }

        /// <summary>
        /// 会员头像
        /// </summary>
        public string MemberIcon { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评论人员类型：0表示会员，1表示管理员
        /// </summary>
        public int Type { get; set; }
    }
}
