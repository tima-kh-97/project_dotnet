using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using project1_milestone.Models.User;
namespace project1_milestone.Models.Visit
{
   
    public class Visit
    {
        
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "VisitDate")]
        public DateTime VisitDate { get; set; }

        [Display(Name = "UserId")]
        public int UserId { get; set; }

        public User.User User { get; set; }

    }
}
