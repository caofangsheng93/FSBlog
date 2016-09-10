using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 文章标签实体
    /// </summary>
   public class ArticleTags:BaseEntity
    {
       /// <summary>
       /// 标签内容
       /// </summary>
       public string TagName { get; set; } 

       /// <summary>
       /// 标签备注
       /// </summary>
       public string TagRemarks { get; set; }

       /// <summary>
       /// 导航属性--文章实体【一个标签可以对应多篇文章，一篇文章可以有多个标签，文章实体和标签实体是多对多的关系】
       /// </summary>
       public ICollection<Article> Articles { get; set; }



    }
}
