using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Orders
{
    /// <summary>
    /// 当订单状态发生改变时，用于记录订单的操作信息。
    /// </summary>
    public class OrderOperateHistory : FullAuditedEntity<int>
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 操作人。用户、系统、后台管理员
        /// </summary>
        public string OperateMan { get; set; }

        /// <summary>
        /// 订单状态。0表示待付款，1表示代发货，2表示已发货，3表示已完成，4表示已关闭，5表示无效订单
        /// </summary>
        public int OrderStatus { get; set; }

        //备注
        public string Note { get; set; }
    }
}
