using MiddlewarePipeline.Models;

namespace MiddlewarePipeline.Controllers;

public class UsersController
{
    private readonly List<User> _users;
    public UsersController(HttpContext context)
    {
        _users = new()
        {
            new User()
            {
                Id = 1,
                Username = "Arezoo",
                Email = "arezoo@example.com"
            },
            new User()
            {
                Id = 2,
                Username = "Ali",
                Email = "ali@example.com"
            }
        };
    }

    public IEnumerable<User> GetAllUsers() => _users;

    public User GetUserById(int id) => _users.Find(t => t.Id == id);
    


}

