using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    class UsersServiceTests
    {
        
        [Theory]
        public void GetUsersListTest()
        {
            var usersService = new UserService();
        }
    }
}
