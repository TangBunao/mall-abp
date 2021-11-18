using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Orders
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Order : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 优惠券Id
        /// </summary>
        public int CouponId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderSN { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string MemberUserName { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 应付金额（实际支付金额）
        /// </summary>
        public decimal PayAmount { get; set; }

        /// <summary>
        /// 运费金额
        /// </summary>
        public decimal FreightAmount { get; set; }

        /// <summary>
        /// 促销优化金额（促销价、满减、阶梯价）
        /// </summary>
        public decimal PromotionAmount { get; set; }

        /// <summary>
        /// 积分抵扣金额
        /// </summary>
        public decimal IntegrationAmount { get; set; }

        /// <summary>
        /// 优惠券抵扣金额
        /// </summary>
        public decimal CouponAmount { get; set; }

        /// <summary>
        /// 管理员后台调整订单使用的折扣金额
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// 支付方式。0表示未支付，1表示支付宝，2表示微信
        /// </summary>
        public int PayType { get; set; }

        /// <summary>
        /// 订单来源。0表示PC订单，1表示app订单
        /// </summary>
        public int SourceType { get; set; }

        /// <summary>
        /// 订单状态。0表示待付款，1表示代发货，2表示已发货，3表示已完成，4表示已关闭，5表示无效订单
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 订单类型。0表示正常订单，1表示秒杀订单
        /// </summary>
        public int OrderType { get; set; }

        /// <summary>
        /// 物流公司（配送方式）
        /// </summary>
        public string DeliveryCompany { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        public string DeliverySN { get; set; }

        /// <summary>
        /// 自动确认时间（天）
        /// </summary>
        public int AutoConfirmDay { get; set; }

        /// <summary>
        /// 可以获得的积分
        /// </summary>
        public int Integration { get; set; }

        /// <summary>
        /// 可以获得的成长值
        /// </summary>
        public int Growth { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 发票类型。0表示不开发票，1表示电子发票，2表示纸质发票
        /// </summary>
        public int BillType { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        public string BillHeader { get; set; }

        /// <summary>
        /// 发票内容
        /// </summary>
        public string BillContent { get; set; }

        /// <summary>
        /// 收票人电话
        /// </summary>
        public string BillReceiverPhone { get; set; }

        /// <summary>
        /// 收票人邮箱
        /// </summary>
        public string BillReceiverEmail { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string ReceiverPostCode { get; set; }

        /// <summary>
        /// 收货人省份/直辖市
        /// </summary>
        public string ReceiverProvince { get; set; }

        /// <summary>
        /// 收货人城市
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收货人区
        /// </summary>
        public string ReceiverRegion { get; set; }

        /// <summary>
        /// 收货人详细地址
        /// </summary>
        public string ReceiverDetailAddress { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 确认收货状态。0表示未确认，1表示已确认
        /// </summary>
        public int ConfirmStatus { get; set; }

        /// <summary>
        /// 下单时使用的积分
        /// </summary>
        public int UseItegration { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime PaymentTime { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime DeliveryTime { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        public DateTime CommentTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

    }
}
