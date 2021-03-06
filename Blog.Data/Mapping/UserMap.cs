﻿using Blog.Entity;
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

           //配置自动增长列
           this.Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           //配置列
           this.Property(s => s.UserName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
           this.Property(s => s.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
           this.Property(s => s.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
           this.Property(s => s.CreatedDate).IsRequired();
           this.Property(s => s.IsDelete).IsOptional();
           this.Property(s => s.IP).HasColumnType("nvarchar").HasMaxLength(50).IsOptional();
           this.Property(s => s.ModifiedDate).IsOptional();

           //配置表名
           this.ToTable("User");
       }
    }
}
