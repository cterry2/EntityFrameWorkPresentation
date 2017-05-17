using System.Linq;
using TheSocialNetwork.Data.Entities;
using TheSocialNetwork.Data.Interface;
using TheSocialNetwork.Service.Interface;

namespace TheSocialNetwork.Service
{
    public class ClientTrackingRepository : IClientTrackingRepository
    {
        private IDbContext _databaseContext { get; set; }
        public ClientTrackingRepository(IDbContext context)
        {
            _databaseContext = context;
        }
        public IQueryable<PersonalInformation> ClientsByCity(string cityName, string stateAbbreviation)
        {
            return _databaseContext.PersonalInformation
                                        .Where(x => x.Addresses
                                                       .Any(y => y.City.Name == cityName && y.State.Abbreviation == stateAbbreviation));
        }

        public IQueryable<PersonalInformation> ClientsByRelationshipStatus(short statusId)
        {
            return _databaseContext.RelationshipStatuses
                                        .First(x => x.Id == statusId)
                                        .PersonalInformation.AsQueryable();
        }

        public IQueryable<PersonalInformation> ClientsByState(string stateAbbreviation)
        {
            return _databaseContext.States
                                        .Where(x => x.Abbreviation == stateAbbreviation)
                                        .SelectMany(x => x.Addresses)
                                        .Select(x => x.PersonalInformation);
        }

        public IQueryable<PersonalInformation> ClientsByZipCode(int zipCode)
        {
            return _databaseContext.Addresses
                                        .Where(x => x.ZipCode == zipCode)                                        
                                        .Select(x => x.PersonalInformation);
        }
    }
}
