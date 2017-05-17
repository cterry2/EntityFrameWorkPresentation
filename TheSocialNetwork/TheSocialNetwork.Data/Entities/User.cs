using System;
using System.Collections.Generic;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class User : ITimeStampEntity
    {
        public long Id { get; set; }
        public string Username { get; set; }        
        public DateTime TimeStamp { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Friendship> FriendShips { get; set; }
        public virtual ICollection<Friendship> MyFriends { get; set; }
    }
}
