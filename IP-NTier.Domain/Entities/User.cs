using System;
using System.Collections.Generic;

namespace IP_NTier.Domain.Entities
{
    public class User : IEntity
    {
        #region Ctor.
        public User()
        {
            UserRole = new HashSet<UserRole>();
            CreatedOn = DateTime.Now;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public string UserName { get; set; }
        
        public DateTime CreatedOn { get; set; }
        #endregion

        #region Navigation_Properties

        public virtual ICollection<UserRole> UserRole { get; set; }
        #endregion
    }
}
