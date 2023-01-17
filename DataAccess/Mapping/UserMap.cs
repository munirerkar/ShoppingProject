using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace DataAccess.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            // Maps to the Users table
            builder.ToTable("Users");

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.FirstName).HasMaxLength(256);
            builder.Property(u => u.LastName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.PhoneNumber).HasMaxLength(13);


            // Each User can have many entries in the UserOperationClaim join table
            builder.HasMany<UserOperationClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
        }
    }
}
