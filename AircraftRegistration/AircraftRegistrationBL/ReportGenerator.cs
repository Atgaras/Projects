using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftRegistrationBL
{
    public class ReportGenerator
    {
        private CompanyRepository _companyRepository;
        private CountryRepository _countryRepository;
        private AircraftRepository _aircraftRepository;
        private AircraftModelRepository _aircraftModelRepository;
        public ReportGenerator
            (CompanyRepository companyRepository,
            CountryRepository countryRepository,
            AircraftRepository aircraftRepository,
            AircraftModelRepository aircraftModelRepository)
        {
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
        }
        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<Aircraft> lektuvai = _aircraftRepository.Retrieve();

            List<ReportItem> ataskaita = new List<ReportItem>();
            
            foreach (var lektuvas in lektuvai)
            {
                Company lektuvoKompanija = _companyRepository.Retrieve(lektuvas.CompanyId);
                Country lektuvoSalis = _countryRepository.Retrieve(lektuvoKompanija.CountryId);
                AircraftModel lektuvoModelis = _aircraftModelRepository.Retrieve(lektuvas.ModelId);


                if (lektuvoSalis.Continent == "Europe")
                {
                    ReportItem eilute = new ReportItem();
                    eilute.AircraftTailNumber = lektuvas.TailNumber;
                    eilute.ModelNumber = lektuvoModelis.Number;
                    eilute.ModelDescription = lektuvoModelis.Description;
                    eilute.OwnerCompanyName = lektuvoKompanija.Name;
                    eilute.CompanyCountryCode = lektuvoSalis.Code;
                    eilute.CompanyCountryName = lektuvoSalis.Name;
                    //eilute.BelongsToEU = ;
                }
            }
               
            return null;
        }
    }
}
