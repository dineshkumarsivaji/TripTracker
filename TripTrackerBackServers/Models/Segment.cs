﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerBackServers.Models
{
    public class Segment
    {
        public int Id { get; set; }

        public int TripId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
            
        public DateTimeOffset StartDateTime { get; set; }

        public DateTimeOffset dateTimeOffset { get; set; }

        

    }
}
