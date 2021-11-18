using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.OrderSettings
{
    public class OrderSetting : FullAuditedEntity<int>
    {
        /// <summary>
        /// 秒杀订单超时关闭时间（分）
        /// </summary>
        public int FlashOrderOvertime { get; set; }

        /// <summary>
        /// 正常订单超时的时间（分）
        /// </summary>
        public int NormalOrderOvertime { get; set; }

        /// <summary>
        /// 发货后自动确认收货的时间（天）
        /// </summary>
        public int ConfirmOvertime { get; set; }

        /// <summary>
        /// 自动完成交易的时间，不能申请售后（天）
        /// </summary>
        public int FinishOvertime { get; set; }

        /// <summary>
        /// 订单完成后自动好评的时间（天）
        /// </summary>
        public int CommentOvertime { get; set; }
    }
}
