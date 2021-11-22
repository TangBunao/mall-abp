using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TangBunao.Mall.HomeRecommendSubjects
{
    /// <summary>
    /// 首页专题推荐表，用于管理首页显示的专题精选信息
    /// </summary>
    public class HomeRecommendSubject : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 专题Id
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// 专题名称
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// 推荐状态。0表示不推荐，1表示推荐
        /// </summary>
        public int RecommendStatus { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
