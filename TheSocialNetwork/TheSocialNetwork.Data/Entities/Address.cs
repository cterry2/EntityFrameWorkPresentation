using System;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class Address : ITimeStampEntity
    {
        public long Id { get; set; }
        public string AddressLine { get; set; }
        public string AddressLineExtended { get; set; }
        public int CityId { get; set; }        
        public int ZipCode { get; set; }
        public int StateId { get; set; }
        public long PersonalInformationId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
        public virtual City City { get; set; }
        public virtual State State { get; set; }
    }
}
