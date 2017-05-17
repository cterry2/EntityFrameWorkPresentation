using System;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class ZipCode : ITimeStampEntity
    {
        public long Id { get; set; }
        public int PostalCode { get; set; }
        public int CityId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual City City { get; set; }
    }
}
