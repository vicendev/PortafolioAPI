using MongoDB.Bson.Serialization.Attributes;
using Org.Sdt.Architecture.Core.Entities;


namespace Org.Sdt.Users.Entities
{
    [BsonCollectionAttribute("User")]
    public class UserEntity : Document
    {
        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("role")]
        public string Role { get; set; }
    }
}
