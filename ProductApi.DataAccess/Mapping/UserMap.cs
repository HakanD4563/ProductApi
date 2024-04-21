using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApi.DataAccess.Mapping.BaseMap;
using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Mapping
{
    public class UserMap:BaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(x=>x.FirstName).HasMaxLength(50);
            builder.Property(x=>x.LastName).HasMaxLength(50);
            builder.Property(x=>x.Email).HasMaxLength(100);
            builder.Property(x=>x.Password).HasMaxLength(16);
            builder.Property(x=>x.Phone).HasMaxLength(10);
            builder.Property(x=>x.UserName).HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
