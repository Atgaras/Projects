﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftRegistrationBL
{
    public class ReportItem
    {
        public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public string BelongsToEU { get; set; }
    }
}
