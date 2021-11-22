using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.OrderReturnApplies
{
    /// <summary>
    /// 订单退后原因表，用于退货时选择退货原因
    /// </summary>
    public class OrderReturnReason : FullAuditedEntity<int>
    {
        /// <summary>
        /// 退货类型
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 状态。0表示不启用，1表示启用
        /// </summary>
        public int Status { get; set; }
    }
}
