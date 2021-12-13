using System;
using System.Collections.Generic;

namespace project.Models
{
    public class Actor
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Country Country { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}