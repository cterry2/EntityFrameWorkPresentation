using System;
using System.Collections.Generic;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class RelationshipStatus : ITimeStampEntity
    {
        public short Id { get; set; }
        public string Value { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformation { get; set; }
    }
}
