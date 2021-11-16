using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductAudits
{
    /// <summary>
    /// 商品审核记录表
    /// </summary>
    public class ProductAuditRecord : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 审核人Id
        /// </summary>
        public int AuditorId { get; set; }

        /// <summary>
        /// 审核后的状态。0表示未通过，2表示已通过
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 反馈详情
        /// </summary>
        public string Detail { get; set; }
    }
}
