using System;
using System.Collections.Generic;

namespace project.ViewModels
{
    public class ActorDTO
    {

        public ActorDTO()
        {

        }
        public ActorDTO(long id, string lastName, string firstName,
            long countryId, string countryCode, string countryName,
            DateTime? dateOfBirth)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.CountryId = countryId;
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.DateOfBirth = dateOfBirth;
        }

        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}