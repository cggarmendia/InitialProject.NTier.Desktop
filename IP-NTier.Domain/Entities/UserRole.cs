using System;

namespace IP_NTier.Domain.Entities
{
    public class UserRole : IEntity
    {
        #region Properties
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string CreatedUser { get; set; }
        #endregion

        #region Navigation_Properties
        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
        #endregion
    }
}
