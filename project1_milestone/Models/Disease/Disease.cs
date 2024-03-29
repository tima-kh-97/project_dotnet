﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.Disease
{
    public class Disease
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }



    }
}
