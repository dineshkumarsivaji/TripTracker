using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerBackServers.Models
{
    public class Repository
    {

        private List<Trip> MyTips = new List<Trip>
        {
            new Trip
            {
                Id =1,
                Name = "MVP Summit",
                StartDate = new DateTime(2018,3,5),
                 EndDate = new DateTime(2018,3,8)
            },
            new Trip
            {
                Id =2,
                Name = "DevIntersection Orlando 2018",
                StartDate = new DateTime(2018,3,25),
                 EndDate = new DateTime(2018,3,27)
            },
            new Trip
            {
                Id =3,
                Name = "MVP Summit",
                StartDate = new DateTime(2018,5,7),
                 EndDate = new DateTime(2018,5,9)
            }
        };

        public List<Trip> Get()
        {
            return MyTips; 
        }

        public Trip Get(int id)
        {
            return MyTips.First(t => t.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTips.Remove(MyTips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTips.Remove(MyTips.First(t => t.Id == id));

        }

    }
}
