using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.FlashPromotions
{
    /// <summary>
    /// 限时购通知记录表，用于存储会员的限时购预约就，当有的限时购场次还未开始时，会员可以进行预约操作，当场次开始后时，系统会进行提醒
    /// </summary>
    public class FlashPromotionLog : FullAuditedEntity<int>
    {
        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 会员电话
        /// </summary>
        public string MemberPhone { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 订阅时间
        /// </summary>
        public DateTime SubscribeTime { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }
    }
}
