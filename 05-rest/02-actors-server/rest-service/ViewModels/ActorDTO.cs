using System;
using System.Collections.Generic;

namespace project.ViewModels
{
    public class ActorDTO
    {

        public ActorDTO(long id, string lastName, string firstName, 
            string countryCode, DateTime? dateOfBirth)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;

        }
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CountryCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}