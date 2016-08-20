using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Entity
{
   public class Category:BaseEntity
    {
       /// <summary>
       /// 分类名称
       /// </summary>
       public string CategoryName { get; set; }

       /// <summary>
       /// 文章编号
       /// </summary>
       public int ArticleId { get; set; }

       /// <summary>
       /// 导航属性
       /// </summary>
       public ICollection<Article> Article { get; set; }


    }
}
