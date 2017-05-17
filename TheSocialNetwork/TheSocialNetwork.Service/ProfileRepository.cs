using System;
using System.Linq;
using TheSocialNetwork.Data.Entities;
using TheSocialNetwork.Data.Interface;
using TheSocialNetwork.Service.Interface;

namespace TheSocialNetwork.Service
{
    public class ProfileRepository : IProfileRepository
    {
        private IDbContext _databaseContext { get; set; }
        public ProfileRepository(IDbContext context)
        {
            _databaseContext = context;
        }
        public PersonalInformation GetPersonalInformation(long userId)
        {
            return _databaseContext.PersonalInformation
                                        .FirstOrDefault(x => x.UserId == userId);
        }
    }
}
