using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.Template
{
    public class Template
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "ObjectiveData")]
        public string ObjectiveData { get; set; }

        [Display(Name = "SubjectiveData")]
        public string SubjectiveData { get; set; }

        [Display(Name = "DiseaseId")]
        public int DiseaseId { get; set; }

        public Disease.Disease Disease { get; set; }

        

    }
}
