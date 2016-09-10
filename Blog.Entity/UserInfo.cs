using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 用户详情实体
    /// </summary>
   public class UserInfo:BaseEntity
    {
        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 出身年月日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 微信号码
        /// </summary>
        public string WeChat { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 用户图像
        /// </summary>
        public string UserImage { get; set; }

       /// <summary>
       /// 是否锁定
       /// </summary>
        public bool IsLock { get; set; }

        /// <summary>
        /// 导航属性--用户实体
        /// </summary>
        public virtual User User { get; set; }
      
    }
}
