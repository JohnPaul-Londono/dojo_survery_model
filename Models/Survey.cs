using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survery_model.Models
{
    
    public class Survey
    {
        [Required(ErrorMessage = "Please enter name.")]
        [MinLength(2,ErrorMessage ="Name must be at least 2 characters.")]
        public string Name{get;set;}

        [Required(ErrorMessage = "Please pick a location.")]
        public string Location{get;set;}

        [Required(ErrorMessage = "Please pick a language.")]
        public string Language{get;set;}

        [MinLength(20,ErrorMessage ="Name must be at least 20 characters.")]
        public string Comments{get;set;}
    }
}