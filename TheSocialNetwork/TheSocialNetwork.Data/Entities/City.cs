using System;
using System.Collections.Generic;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class City : ITimeStampEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public DateTime TimeStamp { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        
        public virtual ICollection<ZipCode> ZipCodes { get; set; } 
    }
}
