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
    public class UserConfiguration : DbContextBaseConfiguration<User>
    {
        #region Ctor.
        public UserConfiguration()
            : base()
        {
            ToTable("User");
            HasKey(e => e.Id);
            Property(p => p.UserName).HasMaxLength(256)
                                     .IsRequired()
                                     .HasUniqueIndexAnnotation("IX_User_UserName", 0);
            Property(p => p.Email).HasMaxLength(256).IsRequired()
                                  .HasUniqueIndexAnnotation("IX_User_Email", 0);
        }
        #endregion
    }
}
