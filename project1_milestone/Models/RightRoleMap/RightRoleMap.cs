using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.RightRoleMap
{
    public class RightRoleMap
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "RoleId")]
        public int RoleId { get; set; }

        public Role.Role Role { get; set; }

        [Required]
        [Display(Name = "RightId")]
        public int RightId { get; set; }

        public Right.Right Right { get; set; }

    }
}
