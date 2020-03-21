using System.Threading.Tasks;

namespace nidos.API
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string user, string password);
        Task<bool> UserExists(string user);
    }
}