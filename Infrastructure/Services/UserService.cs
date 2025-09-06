using Application.Interfaces.Repositories;
using Application.Interfaces.Service;

namespace Infrastructure.Services;

public class UserService(IUserRepo userRepo) : IUserService
{
    public string GetUser()
    {
        return userRepo.GetUser();
    }
}