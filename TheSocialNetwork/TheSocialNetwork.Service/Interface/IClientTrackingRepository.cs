using System.Linq;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Service.Interface
{
    public interface IClientTrackingRepository
    {
        IQueryable<PersonalInformation> ClientsByState(string stateAbbreviation);
        IQueryable<PersonalInformation> ClientsByCity(string cityName, string stateAbbreviation);
        IQueryable<PersonalInformation> ClientsByZipCode(int zipCode);
        IQueryable<PersonalInformation> ClientsByRelationshipStatus(short statusId);
    }
}
