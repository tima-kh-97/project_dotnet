
using Moq;
using project1_milestone.Models.User;
using project1_milestone.Repository;
using project1_milestone.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    public class UsersServiceTests
    {

        [Fact]
        public async void AddTest()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            var user = new User() { Name = "Test", Surname = "Test" };
            userService.Create(user);
        }

        [Fact]
        public void GetDetails()
        {

        }

        [Fact]
        public void Create()
        {

        }

        [Fact]
        public void VerifyForExistence()
        {

        }

        [Fact]
        public void Edit()
        {

        }

        [Fact]
        public void Delete()
        {

        }

        [Fact]
        public void UserExists()
        {

        }

        private object Mock<T>()
        {
            throw new NotImplementedException();
        }

    }
}
