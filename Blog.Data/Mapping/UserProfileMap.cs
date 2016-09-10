using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
   public class UserProfileMap:EntityTypeConfiguration<UserProfile>
    {
       public UserProfileMap()
       {
           //配置主键
           this.HasKey(s => s.ID);

           this.Property(s => s.Birthday).IsOptional();
           this.Property(s => s.CreatedDate).IsRequired();
           this.Property(s => s.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsOptional();
           this.Property(s => s.IP).IsOptional();
           this.Property(s => s.IsDelete).IsOptional();
           this.Property(s => s.IsLock).IsOptional();
           this.Property(s => s.LastName).HasColumnType("nvarchar").HasMaxLength(50).IsOptional();



       }
    }
}
