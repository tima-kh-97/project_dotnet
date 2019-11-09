using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.MenuRightMap
{
    public class MenuRightMap
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "MenuId")]
        public int MenuId { get; set; }

        public Menu.Menu Menu { get; set; }

        [Display(Name = "RightId")]
        public int RightId { get; set; }

        public Right.Right Right { get; set; }

    }
}
