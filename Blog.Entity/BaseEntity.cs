using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    /// <summary>
    /// 实体基类
    /// </summary>
   public abstract class BaseEntity
    {
       /// <summary>
       /// ID
       /// </summary>
       public int ID { get; set; }

       /// <summary>
       /// 创建时间
       /// </summary>
       public DateTime CreatedDate { get; set; }

       /// <summary>
       /// 修改时间
       /// </summary>
       public DateTime ModifiedDate { get; set; }

       /// <summary>
       /// IP地址
       /// </summary>
       public string IP { get; set; }
    }
}
