using Blog.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
   public class UserMap:EntityTypeConfiguration<User>
    {
       public UserMap()
       {
           //配置主键
           this.HasKey(s => s.ID);
           this.Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


       }
    }
}
