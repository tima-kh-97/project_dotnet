using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.UserRoleMap
{
    public class UserRoleMap
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "UserId")]
        public int UserId { get; set; }

        public User.User User { get; set; }

        [Display(Name = "RoleId")]
        public int RoleId { get; set; }

        public Role.Role Role { get; set; }

    }
}
