using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.User
{
    public class User
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Middlename")]
        public string Middlename { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

    }
}
