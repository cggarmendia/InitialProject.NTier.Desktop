using System;
using IP_NTier.Business.DomainServices.Modules.Security;
using IP_NTier.Domain.Entities;

namespace IP_NTier.Business.DomainServices.Mapper
{
    internal class DomainServicesMapper
    {
        #region User - UserDto
        internal static UserDto MapToUserDto(User domain)
        {
            var dto = new UserDto();
            if (domain != null)
                dto = new UserDto()
                {
                    Email = domain.Email,
                    Id = domain.Id,
                    PhoneNumber = domain.PhoneNumber,
                    UserName = domain.UserName
                };
            return dto;
        }

        internal static void MapToUser(UserDto dto, User domain = null)
        {
            if (domain == null)
                domain = new User();

            domain.Email = dto.Email;
            domain.EmailConfirmed = dto.EmailConfirmed;
            domain.PhoneNumber = dto.PhoneNumber;
            domain.UserName = dto.UserName;
            domain.PasswordHash = dto.PasswordHash;
            domain.PhoneNumberConfirmed = dto.PhoneNumberConfirmed;
        }
        #endregion
        
        #region Role - RoleDto
        internal static RoleDto MapToRoleDto(Role domain)
        {
            var dto = new RoleDto();
            if (domain != null)
                dto = new RoleDto()
                {
                    Name = domain.Name,
                    Id = domain.Id
                };
            return dto;
        }

        internal static void MapToRole(RoleDto dto, Role domain = null)
        {
            if (domain == null)
                domain = new Role();

            domain.Name = dto.Name;
        }
        #endregion
    }
}