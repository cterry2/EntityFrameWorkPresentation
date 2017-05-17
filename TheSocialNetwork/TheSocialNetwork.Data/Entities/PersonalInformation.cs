using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class PersonalInformation : ITimeStampEntity
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public short RelationshipStatusId { get; set; }
        public long? SignificantOtherId { get; set; }        
        public long UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SignificantOtherId")]
        public virtual PersonalInformation SignificantOther { get; set; }
        public virtual User User { get; set; }
        public virtual RelationshipStatus RelationshipStatus { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
