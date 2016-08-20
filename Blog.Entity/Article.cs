using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 文章实体
    /// </summary>
   public class Article:BaseEntity
    {
       /// <summary>
       /// 文章标题
       /// </summary>
       public string Title { get; set; }

       /// <summary>
       /// 文章内容
       /// </summary>
       public string Content { get; set; }

       /// <summary>
       /// 分类ID
       /// </summary>
       public int CategoryId { get; set; }

       /// <summary>
       /// 作者编号
       /// </summary>
       public int UserId { get; set; }

       /// <summary>
       /// 导航属性--User
       /// </summary>
       public virtual User User { get; set; }

       /// <summary>
       /// 导航属性--分类
       /// </summary>
       public virtual ICollection<Category> Category { get; set; }




    }
}
