using project1_milestone.Data;
using project1_milestone.Models.User;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project1_milestone.Repository;

namespace project1_milestone.Services
{
    public class UsersService
    {

        private readonly IUserRepository _userRepository;

        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsersList()
        {
            return _userRepository.GetUsersList();
        } 

        public User GetDetails(int? Id)
        {
            if (Id == null)
            {
                return null;
            }

            return _userRepository.GetDetails(Id);
        }

        public async void Create(User user)
        {
            _userRepository.Create(user);
        }

        public Task<User> VerifyForExistence(string Phone)
        {
            return _userRepository.VerifyForExistence(Phone);     
        }

        public User Edit(int? Id)
        {
            if (Id == null)
            {
                return null;
            }
            return _userRepository.Edit(Id);

        }

        public async void Edit(User user)
        {
            _userRepository.Edit(user);
        }

        public User Delete(int? id)
        {
           return _userRepository.Delete(id);
        }

        public void DeleteConfirmed(int id)
        {
            _userRepository.DeleteConfirmed(id);
        }

        public bool UserExists(int id)
        {
            return _userRepository.UserExists(id);
        }
    }
}
