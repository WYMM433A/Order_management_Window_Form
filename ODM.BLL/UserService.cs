using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODM.DAL;

namespace ODM.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string username, string password)
        {
            var user = _userRepository.Authenticate(username, password);
            if (user == null)
                throw new System.Exception("Invalid credentials or account is locked.");
            return user;
        }
    }
}
