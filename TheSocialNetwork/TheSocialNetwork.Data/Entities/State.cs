using System;
using System.Collections.Generic;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class State : ITimeStampEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Abbreviation { get; set; }
        public DateTime TimeStamp { get; set; }

        
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
