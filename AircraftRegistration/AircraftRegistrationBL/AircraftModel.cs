﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftRegistrationBL
{
    public class AircraftModel
    {
        public AircraftModel()
        {

        }

        public AircraftModel(int id, string number, string description)
        {
            Id = id;
            Number = number;
            Description = description;
        }
        public int Id { get; private set; }
        public string Number { get; set; }
        public string Description { get; set; }


        public AircraftModel Retrieve(int Id)
        {
            return new AircraftModel();
        }
        public List<AircraftModel> Retrieve()
        {
            return new List<AircraftModel>();
        }

    }
}
