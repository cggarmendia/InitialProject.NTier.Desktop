using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IP_NTier.Common.DataAccess.EF.Configuration;
using IP_NTier.Common.DataAccess.EF.Extensions;
using IP_NTier.Domain.Entities;

namespace IP_NTier.DataAccess.EF.Configuration
{
    public class UserRoleConfiguration : DbContextBaseConfiguration<UserRole>
    {
        #region Ctor.
        public UserRoleConfiguration()
            : base()
        {
            ToTable("UserRole");

            HasKey(ur => new {ur.UserId, ur.RoleId });

            HasRequired(ur => ur.User)
                .WithMany(u => u.UserRole)
                .HasForeignKey(ur => ur.UserId);

            HasRequired(ur => ur.Role)
                .WithMany(u => u.UserRole)
                .HasForeignKey(ur => ur.RoleId);

            Property(p => p.CreatedUser).HasMaxLength(256)
                                        .IsRequired();
        }
        #endregion
    }
}
