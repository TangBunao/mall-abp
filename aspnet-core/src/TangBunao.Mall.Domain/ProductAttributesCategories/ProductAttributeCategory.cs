using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.ProductAttributesCategories
{
    /// <summary>
    /// 商品属性分类表
    /// </summary>
    public class ProductAttributeCategory : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 商品属性分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 该分类下的属性数量
        /// </summary>
        public int AttributeCount { get; set; }

        /// <summary>
        /// 该分类下的参数数量
        /// </summary>
        public int ParamCount { get; set; }

        public ICollection<ProductAttribute> Attributes { get; private set; }

        public ICollection<ProductAttribute> Params { get; private set; }

        private ProductAttributeCategory()
        {

        }

        public ProductAttributeCategory(string name, int attributeCount = 0, int paramCount = 0)
        {
            Name = name;
            AttributeCount = attributeCount;
            ParamCount = paramCount;

            Attributes = new Collection<ProductAttribute>();
            Params = new Collection<ProductAttribute>();
        }

        public void AddAttribute(ProductAttribute attribute)
        {
            Attributes.Add(attribute);
        }

        public void DeleteAttribute(int attributeId)
        {
            var attribute = Attributes.FirstOrDefault<ProductAttribute>(a => a.Id == attributeId);
            if (attribute != null)
            {
                Attributes.Remove(attribute);
            }
        }        
    }
}
