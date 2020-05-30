using IP_NTier.Domain.Entities;

namespace IP_NTier.Domain.SecurityServices
{
    public interface IAuthenticationService
    {
        User AuthenticateUser(string username, string password);
    }
}
