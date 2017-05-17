using System;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class Friendship : ITimeStampEntity
    {        
        public long UserId { get; set; }
        public long FriendId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual User User { get; set; }
        public virtual User Friend { get; set; }
    }
}
