using project1_milestone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Repository
{
    public interface IUserRepository
    {

        List<User> GetUsersList();
        User GetDetails(int? id);
        void Create(User user);
        Task<User> VerifyForExistence(string Phone);
        User Edit(int? id);
        void Edit(User user);
        User Delete(int? id);
        void DeleteConfirmed(int id);
        bool UserExists(int id);

    }
}
