using IP_NTier.Common.DataAccess.EF.Configuration;
using IP_NTier.Common.DataAccess.EF.Extensions;
using IP_NTier.Domain.Entities;

namespace IP_NTier.DataAccess.EF.Configuration
{
    public class RoleConfiguration : DbContextBaseConfiguration<Role>
    {
        #region Ctor.
        public RoleConfiguration()
            : base()
        {
            ToTable("Role");
            HasKey(e => e.Id);
            Property(p => p.Name).HasMaxLength(256)
                                 .IsRequired()
                                 .HasUniqueIndexAnnotation("IX_Role_Name", 0);
        }
        #endregion
    }
}
