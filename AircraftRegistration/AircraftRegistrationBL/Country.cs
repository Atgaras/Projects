using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftRegistrationBL
{
    public class Country
    {
        //countryCodes.Add(new Country(1,'LT','Lithuania','Europe','T'));
        public Country()
        {

        }

        public Country(int countryId, string countryCode, string countryName, string continent, bool? belongsToEU)
        {
            Id = countryId;
            Code = countryCode;
            Name = countryName;
            Continent=continent;
            BelongsToEU = belongsToEU;
        }

        public int Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool? BelongsToEU { get; set; }
        public Country Retrieve(int Id)
        {
            return new Country();
        }
        public List<Country> Retrieve()
        {
            return new List<Country>();
        }
    }
}
