using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 文章阅读统计实体
    /// </summary>
   public class ArticleStatistics:BaseEntity
    {
       /// <summary>
       /// 阅读数量
       /// </summary>
       public int ReadNumber { get; set; }

       /// <summary>
       /// 文章编号
       /// </summary>
       public int ArticleId { get; set; }

       /// <summary>
       /// 导航属性--文章实体【阅读统计和文章实体之间一对多关系】
       /// </summary>
       public virtual Article Article { get; set; }
    }
}
