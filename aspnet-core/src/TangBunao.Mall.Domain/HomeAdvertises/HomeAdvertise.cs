using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.HomeAdvertises
{
    /// <summary>
    /// 首页轮播广告表，用于管理首页显示的轮播广告信息
    /// </summary>
    public class HomeAdvertise:FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 轮播位置。0表示PC首页轮播，1表示APP首页轮播
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string Pic { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 上下线状态。0表示下线，1表示上线
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 点击数
        /// </summary>
        public int ClickCount { get; set; }

        /// <summary>
        /// 下单数
        /// </summary>
        public int OrderCount { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
