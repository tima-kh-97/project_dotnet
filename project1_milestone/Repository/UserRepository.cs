using project1_milestone.Data;
using project1_milestone.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace project1_milestone.Repository
{
    public class UserRepository : IUserRepository
    {

        readonly DBContext _dbContext;

        public UserRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void Create(User user)
        {
            _dbContext.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public User Delete(int? id)
        {
            return _dbContext.User.FirstOrDefault(m => m.Id == id);
        }

        public void DeleteConfirmed(int id)
        {
            var user = _dbContext.User.Find(id);
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }

        public User Edit(int? id)
        {
            return _dbContext.User.Find(id);
        }

        public async void Edit(User user)
        {
            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public User GetDetails(int? id)
        {
            return _dbContext.User.FirstOrDefault(m => m.Id == id);
        }

        public List<User> GetUsersList()
        {
            return _dbContext.User.ToList();
        }

        public bool UserExists(int id)
        {
            return _dbContext.User.Any(e => e.Id == id);
        }

        public async Task<User> VerifyForExistence(string Phone)
        {
            return await _dbContext.User.FirstOrDefaultAsync(u => u.Phone == Phone);
        }
    }
}
