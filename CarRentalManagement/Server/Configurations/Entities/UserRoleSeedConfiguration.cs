using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                    UserId = "1728f69c-93d3-4f87-adfd-72c613c4c000"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "dfd84aca-2438-4447-b68d-20ec959ff92b",
                    UserId = "7ea9571d-711e-4dc2-a670-b81e1a72b440"
                }


            );
        }
    }
}
