using MongoDB.Bson.Serialization.Attributes;
using Org.Sdt.Architecture.Core.Entities;

namespace Org.Sdt.Projects.Entities
{
    [BsonCollectionAttribute("Project")]
    public class ProjectEntity : Document
    {
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
