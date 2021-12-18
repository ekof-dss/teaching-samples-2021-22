using System;
using System.Collections.Generic;

namespace project.Models
{
    public partial class Actor
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public DateTime? DateOfBith { get; set; }
    }
}