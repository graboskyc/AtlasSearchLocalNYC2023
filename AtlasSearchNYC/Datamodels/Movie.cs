using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AtlasSearchNYC.Datamodels
{
    [BsonIgnoreExtraElements]
    public class Movie {
        public ObjectId _id {get;set;}
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("fullplot")]
        public string Plot { get; set; }
        [BsonElement("poster")]
        public string? PosterImageUrl { get; set; }
        [BsonElement("year")]
        public dynamic Year { get; set; }
        [BsonElement("genres")]
        public List<string> Genres { get; set; }
        [BsonElement("cast")]
        public List<string> Cast { get; set; }
        
        [BsonElement("score")]
        public double? SearchScore { get; set; } = null;
        [BsonElement("highlights")]
        public List<Highlight> Highlights {get;set;} = new List<Highlight>();
    }
}