using System;
using System.Collections.Generic;

namespace AircraftRegistrationBL
{
    public class Aircraft
    {
        public Aircraft()
        {

        }

        public Aircraft(int aircraftId, int modelId, int companyId, string tailNumber)
        {
            AircraftId = aircraftId;
            ModelId = modelId;
            CompanyId = companyId;
            TailNumber = tailNumber;
        }
        public int AircraftId { get; private set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string TailNumber { get; set; }

        public Aircraft Retrieve(int aircraftId)
        {
            return new Aircraft();
        }
        public List<Aircraft> Retrieve()
        {
            return new List<Aircraft>();
        }

    }

}
