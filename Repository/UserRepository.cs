using LeandroCurioso.EntityFrameworkCore.Poc.Data;
using LeandroCurioso.EntityFrameworkCore.Poc.Models;

namespace LeandroCurioso.EntityFrameworkCore.Poc.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EntityDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
