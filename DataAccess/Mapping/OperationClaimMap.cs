using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            // Primary key
            builder.HasKey(r => r.OperationClaimId);

            // Maps to the AspNetRoles table
            builder.ToTable("OperationClaims");

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);

            // Each Role can have many entries in the UserOperationClaim join table
            builder.HasMany<UserOperationClaim>().WithOne().HasForeignKey(ur => ur.OperationClaimId).IsRequired();

            builder.HasData(new OperationClaim
            {
                OperationClaimId = 1,
                Name = "Superadmin",
            },
            new OperationClaim
            {
                OperationClaimId = 2,
                Name = "admin",
            },
            new OperationClaim
            {
                OperationClaimId = 3,
                Name = "User",
            });
        }
    }
}
