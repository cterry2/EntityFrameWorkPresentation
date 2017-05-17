using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Service.Interface
{
    public interface IProfileRepository
    {
        PersonalInformation GetPersonalInformation(long userId);
    }
}
