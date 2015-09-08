using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SharpStandup.Models
{
    public class CreateReportResponse
    {
        public string Yesterday { get; set; }

        [Required(ErrorMessage="Please enter what you plan to work on today")]
        public string Today { get; set; }

        public string Impediments { get; set; }

        [Required(ErrorMessage="Please enter your name")]
        public string Username { get; set; }
    }
}