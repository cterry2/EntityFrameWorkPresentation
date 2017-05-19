using System;
using TheSocialNetwork.Data.Interface;

namespace TheSocialNetwork.Data.Entities
{
    public class Post : ITimeStampEntity
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime TimeStamp { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
