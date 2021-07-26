using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Org.Sdt.Projects.Entities
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("summary")]
        public string Summary { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("imageSource")]
        public string ImageSource { get; set; }

        [BsonElement("repositoryUrl")]
        public string RepositoryUrl { get; set; }

        [BsonElement("siteUrl")]
        public string SiteUrl { get; set; }
    }
}
