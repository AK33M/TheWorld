using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        void AddTrip(Trip newTrip);
        void AddStop(string tripName, Stop newStop, string username);

        Task<bool> SaveChangesAsync();
        Trip GetTripByName(string tripName, string userName);
        IEnumerable<Trip> GetUserTripsWithStops(string name);
    }
}