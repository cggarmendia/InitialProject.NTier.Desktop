using System.Collections.Generic;

namespace IP_NTier.Domain.Entities
{
    public class Role : IEntity
    {
        #region Ctor.
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Name { get; set; }
        #endregion
        
        #region Navigation_Properties
        public virtual ICollection<UserRole> UserRole { get; set; }
        #endregion
    }
}
