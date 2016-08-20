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
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 微信号码
        /// </summary>
        public string WebChat { get; set; }

        /// <summary>
        /// 兴趣爱好
        /// </summary>
        public string Hobby { get; set; }

        /// <summary>
        /// 导航属性--文章实体
        /// </summary>
        public ICollection<Article> Article { get; set; }

        

    }
}
