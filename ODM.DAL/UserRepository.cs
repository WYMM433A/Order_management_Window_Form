using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODM.DAL
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public User Authenticate(string username, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.UserName == username && u.Password == password && !u.Lock);
        }
    }
}
