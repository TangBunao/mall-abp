using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.FlashPromotions
{
    /// <summary>
    /// 限时购表，用于存储限时购活动的信息
    /// </summary>
    public class FlashPromotion:FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 上下线状态。0表示下线，1表示上线
        /// </summary>
        public int Status { get; set; }        
    }
}
