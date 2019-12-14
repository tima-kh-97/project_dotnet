
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
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            userService.GetDetails(1);
        }

        [Fact]
        public void Create()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            var user = new User() { Name = "Test", Surname = "Test" };
            userService.Create(user);
        }

        [Fact]
        public void VerifyForExistence()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            var Phone = "87012323080";
            userService.VerifyForExistence(Phone);
        }

        [Fact]
        public void Edit()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            var user = new User() {Id = 1, Name = "Test", Surname = "Test" };
            userService.Edit(user);
        }

        [Fact]
        public void Delete()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            userService.Delete(2);
        }

        [Fact]
        public void UserExists()
        {
            var fakeRepository = Moq.Mock.Of<IUserRepository>();
            var userService = new UsersService(fakeRepository);

            userService.UserExists(2);
        }

        private object Mock<T>()
        {
            throw new NotImplementedException();
        }

    }
}
