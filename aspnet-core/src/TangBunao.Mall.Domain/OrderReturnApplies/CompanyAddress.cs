using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.OrderReturnApplies
{
    /// <summary>
    /// 公司收货地址表，用于处理退货申请时选择的收货地址
    /// </summary>
    public class CompanyAddress : FullAuditedEntity<int>
    {
        /// <summary>
        /// 地址名称
        /// </summary>
        public string AddressName { get; set; }

        /// <summary>
        /// 默认发货地址。0表示否，1表示是
        /// </summary>
        public int SendStatus { get; set; }

        /// <summary>
        /// 默认收货地址。0表示否，1表示是
        /// </summary>
        public int ReceiveStatus { get; set; }

        /// <summary>
        /// 收发货人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 收发货人电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 省/直辖市
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string DetailAddress { get; set; }
    }
}
