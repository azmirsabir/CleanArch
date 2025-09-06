using Application.Interfaces.Repositories;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepo
{
    public string GetUser()
    {
        return "Azmir Sabir";
    }
}