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

        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        public User.User User { get; set; }

        [Required]
        [Display(Name = "RoleId")]
        public int RoleId { get; set; }

        public Role.Role Role { get; set; }

    }
}
