using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Driver;
using WebApplication2.Models.Travel;
using WebApplication2.Models.User;
using WebApplication2.Utilities;

namespace WebApplication2.Models;

public interface IChosenTripsRepository
{
    DbSet<ChosenTripsModel> GetChosenTrips();
    IQueryable<ChosenTripsModel> GetUsers(Guid travelId);
    IQueryable<ChosenTripsModel> GetTravels(Guid userId);
    void SetTripRating(DriverRatingDTO rating);
    public void Save();
}