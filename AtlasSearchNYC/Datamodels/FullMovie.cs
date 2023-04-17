using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AtlasSearchNYC.Datamodels
{
    [BsonIgnoreExtraElements]
    public class FullMovie {
        public ObjectId _id {get;set;}
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("plot")]
        public string ShortPlot { get; set; }
        [BsonElement("poster")]
        public string? PosterImageUrl { get; set; }
        [BsonElement("year")]
        public dynamic Year { get; set; }
        [BsonElement("genres")]
        public List<string> Genres { get; set; }
        [BsonElement("cast")]
        public List<string> Cast { get; set; }
        [BsonElement("duration")]
        public dynamic Duration { get; set; }
        [BsonElement("fullplot")]
        public string FullPlot { get; set; }
        [BsonElement("languages")]
        public List<string> Languages { get; set; }
        [BsonElement("rated")]
        public string MPAARating { get; set; }
        [BsonElement("released")]
        public DateTime ReleaseDate {get;set;}
        
    }
}

