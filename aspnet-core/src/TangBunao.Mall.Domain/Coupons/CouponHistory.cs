using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Coupons
{
    /// <summary>
    /// 优惠券历史记录表，用于存储会员领取以及使用优惠券的记录，当会员领取到优惠券时，会产生一条优惠券记录
    /// </summary>
    public class CouponHistory : FullAuditedEntity<int>
    {
        /// <summary>
        /// 优惠券Id
        /// </summary>
        public int CouponId { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        //订单Id
        public int OrderId { get; set; }

        /// <summary>
        /// 优惠券码
        /// </summary>
        public string CouponCode { get; set; }

        /// <summary>
        /// 领取人昵称
        /// </summary>
        public string MemberNickName { get; set; }

        /// <summary>
        /// 获取类型。0表示后台赠送，1表示主动获取
        /// </summary>
        public int ReceiveType { get; set; }

        /// <summary>
        /// 使用状态。0表示未使用，1表示已使用，2表示已过期
        /// </summary>
        public int UseStatus { get; set; }

        /// <summary>
        /// 使用时间
        /// </summary>
        public DateTime UseTime { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderSN { get; set; }
    }
}
