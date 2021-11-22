using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Coupons
{
    /// <summary>
    /// 优惠券表，用于存储优惠券信息
    /// </summary>
    public class Coupon : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 优惠券类型。0表示全场赠券，1表示会员赠券，2表示购物赠券，3表示注册赠券
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 使用平台。0表示全部，1表示移动，2表示PC
        /// </summary>
        public int Platform { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 每人限领张数
        /// </summary>
        public int PerLimit { get; set; }

        /// <summary>
        /// 使用门槛。0表示无门槛
        /// </summary>
        public decimal MinPoint { get; set; }

        /// <summary>
        /// 开始使用时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束使用时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 使用类型。0表示全场通用，1表示指定分类，2表示指定商品
        /// </summary>
        public int UseType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 发行数量
        /// </summary>
        public int PublishCount { get; set; }

        /// <summary>
        /// 已使用数量
        /// </summary>
        public int UseCount { get; set; }

        /// <summary>
        /// 领取数量
        /// </summary>
        public int ReceiveCount { get; set; }

        /// <summary>
        /// 可以领取的日期
        /// </summary>
        public DateTime EnableTime { get; set; }

        /// <summary>
        /// 优惠码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 可领取的会员登记。0表示无限制
        /// </summary>
        public int MemberLevel { get; set; }
    }
}
