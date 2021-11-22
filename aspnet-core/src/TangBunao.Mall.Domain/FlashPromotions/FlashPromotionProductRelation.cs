using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.FlashPromotions
{
    /// <summary>
    /// 限时购与商品关系表，用于存储与限时购相关的商品信息，一个限时购中有多个场次，每个场次都可以设置不同的活动商品
    /// </summary>
    public class FlashPromotionProductRelation : FullAuditedEntity<int>
    {
        /// <summary>
        /// 限时购Id
        /// </summary>
        public int FlashPromotionId { get; set; }

        /// <summary>
        /// 限时购场次Id
        /// </summary>
        public int FlashPromotionSessionId { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 限时购价格
        /// </summary>
        public decimal FlashPromotionPrice { get; set; }

        /// <summary>
        /// 限时购数量
        /// </summary>
        public int FlashPromotionCount { get; set; }

        /// <summary>
        /// 限时购每人限购数量
        /// </summary>
        public int FlashPromotionLimit { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
