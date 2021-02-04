using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FilmCollection.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Please enter a Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter a Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter a Director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}
