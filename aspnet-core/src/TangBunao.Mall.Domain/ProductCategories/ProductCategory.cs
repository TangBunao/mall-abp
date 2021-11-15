using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangBunao.Mall.AuditingContracts;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductCategories
{
    public class ProductCategory : AuditedAggregateRoot<int>, ISoftDelete, IDeletionAuditedObject
    {
        /// <summary>
        /// 上级分类的编号。0表示一级分类
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分类级别：0表示一级，1表示2级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        public string ProductUnit { get; set; }

        /// <summary>
        /// 是否显示在导航栏。0表示不显示，1表示显示
        /// </summary>
        public int NavStatus { get; set; }

        /// <summary>
        /// 显示状态。0表示不显示，1表示显示
        /// </summary>
        public int ShowStatus { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 删除状态。0表示未删除，1表示已删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 执行删除操作的用户Id
        /// </summary>
        public Guid? DeletedById { get; set; }

        /// <summary>
        /// 删除的时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }
    }
}
