using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.Device
{
    public class Device
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "DeviceName")]
        public string DeviceName { get; set; }

        [Display(Name = "UserId")]
        public int UserId { get; set; }

        public User.User User { get; set; }

    }
}
