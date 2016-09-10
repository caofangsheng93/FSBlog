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
       /// 文章链接
       /// </summary>
       public string ArticleUrl { get; set; }

       /// <summary>
       /// 是否置顶
       /// </summary>
       public bool IsShowTop { get; set; }

       /// <summary>
       /// 是否转载
       /// </summary>
       public bool IsReprint { get; set; }

       /// <summary>
       /// 转载的原文链接
       /// </summary>
       public string ReprintUrl { get; set; }

       /// <summary>
       /// 文章作者编号【一个用户有多篇文章，外键在多的一方实体上】
       /// </summary>
       public int UserId { get; set; }

       /// <summary>
       /// 导航属性--User【用户和文章之间一对多关系】
       /// </summary>
       public virtual User User { get; set; }

       /// <summary>
       /// 导航属性--分类【文章和分类之间多对多关系】
       /// </summary>
       public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }

       /// <summary>
       ///  导航属性--标签【文章和标签之间多对多关系】
       /// </summary>
       public virtual ICollection<ArticleTags> ArticleTags { get; set; }

       /// <summary>
       /// 导航属性--评论【评论和文章之间一对多关系】
       /// </summary>
       public virtual ICollection<ArticleComment> ArticleComments { get; set; }

    }
}
