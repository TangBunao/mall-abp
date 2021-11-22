using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.OrderReturnApplies
{
    /// <summary>
    /// 订单退货申请表，用于存储会员退货申请信息。
    /// </summary>
    public class OrderReturnApply : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 收货地址表Id
        /// </summary>
        public int CompanyAddressId { get; set; }

        /// <summary>
        /// 退货商品Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderSN { get; set; }

        /// <summary>
        /// 会员用户名
        /// </summary>
        public string MemberUserName { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal ReturnAmount { get; set; }

        /// <summary>
        /// 退货人姓名
        /// </summary>
        public string ReturnName { get; set; }

        /// <summary>
        /// 退货人电话
        /// </summary>
        public string ReturnPhone { get; set; }

        /// <summary>
        /// 申请状态。0表示待处理，1表示退货中，2表示已完成，3表示已拒绝。
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime HandleTime { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        public string ProductPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public string ProductBrand { get; set; }

        /// <summary>
        ///  商品销售属性
        /// </summary>
        public string ProductAttr { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// 商品实际支付单价
        /// </summary>
        public decimal ProductRealPrice { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 凭证图片，以逗号隔开
        /// </summary>
        public string ProofPics { get; set; }

        /// <summary>
        /// 处理备注
        /// </summary>
        public string HandleNote { get; set; }

        /// <summary>
        /// 处理人员
        /// </summary>
        public string HandleMan { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string ReceiveMan { get; set; }

        /// <summary>
        /// 收货时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// 收货备注
        /// </summary>
        public string ReceiveNote { get; set; }

    }
}
