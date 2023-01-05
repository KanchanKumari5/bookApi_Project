using BookStore_API.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookStore_API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);

        Task<string> LoginAsync(SignInModel signInModel);
    }
}
