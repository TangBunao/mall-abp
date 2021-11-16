using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.Products
{
    /// <summary>
    /// 根据不同会员等级，可以以不同的会员价格购买。此处设计有缺陷，可以做成不同会员等级可以减免多少元或者按多少折扣进行购买。
    /// </summary>
    public class ProductMemberPrice : FullAuditedEntity<int>
    {
        public int ProductId { get; set; }

        public int MemberLevelId { get; set; }

        public decimal Price { get; set; }

        public string MemberLevelName { get; set; }
    }
}
