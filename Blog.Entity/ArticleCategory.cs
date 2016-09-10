using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Entity
{
    /// <summary>
    /// 文章文类实体
    /// </summary>
   public class ArticleCategory:BaseEntity
    {
       /// <summary>
       /// 分类名称
       /// </summary>
       public string CategoryName { get; set; }

       /// <summary>
       /// 分类备注
       /// </summary>
       public string CategoryRemark { get; set; }

       /// <summary>
       /// 导航属性--文章实体【文章和分类之间多对多】
       /// </summary>
       public virtual ICollection<Article> Article { get; set; }


    }
}
