using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.FlashPromotions
{
    /// <summary>
    /// 用于存储限时购 场次的信息，在一天中，一个限时购互动会有多个不同的活动时间段
    /// </summary>
    public class FlashPromotionSession:FullAuditedEntity<int>
    {
        /// <summary>
        /// 场次名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 每日开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 每日结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 启用状态。0表示不启用，1表示启用
        /// </summary>
        public int Status { get; set; }
    }
}
