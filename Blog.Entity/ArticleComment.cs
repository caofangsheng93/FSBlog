using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 评论实体
    /// </summary>
   public class ArticleComment:BaseEntity
    {
       /// <summary>
       /// 评论内容
       /// </summary>
       public string CommnetContent { get; set; }

       /// <summary>
       /// 评论时间
       /// </summary>
       public DateTime CommentDate { get; set; }

       /// <summary>
       /// 一篇文章可以有多条评论【外键在多的评论实体上】
       /// </summary>
       public int ArticleId { get; set; }

       /// <summary>
       /// 一个评论只能是有一个用户发的，一个用户可以有多条评论【外键在多的评论实体上】
       /// </summary>
       public int UserId { get; set; }

       /// <summary>
       /// 一个评论内容只能有一个用户，一个用户可以有多条评论【评论和用户之间是一对多的关系】
       /// </summary>
       public virtual User User { get; set; }

       /// <summary>
       /// 导航属性--文章实体【一篇文章有多条评论，一条评论可以针对一篇文章，评论实体和文章实体之间是一对多关系】
       /// </summary>
       public virtual Article Article { get; set; }


    }
}
