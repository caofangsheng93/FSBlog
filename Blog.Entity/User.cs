using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class User:BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 导航属性----文章实体【一个用户可以写多篇文章】
        /// </summary>
        public virtual ICollection<Article> Articles { get; set; }

        /// <summary>
        ///导航属性---用户详情实体【一个用户只能有一个用户详情】
        /// </summary>
        public virtual UserProfile UserProfile { get; set; }

        /// <summary>
        /// 导航属性--评论实体【一个用户可以有很多评论】
        /// </summary>
        public virtual ICollection<ArticleComment> ArticleComments { get; set; }

    }
}
