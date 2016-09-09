using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Entity
{
    /// <summary>
    /// 文章文类实体
    /// </summary>
   public class Category:BaseEntity
    {
       /// <summary>
       /// 分类名称
       /// </summary>
       public string CategoryName { get; set; }

       /// <summary>
       /// 导航属性
       /// </summary>
       public virtual ICollection<Article> Article { get; set; }


    }
}
