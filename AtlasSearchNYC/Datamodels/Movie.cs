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
        [BsonElement("year")]
        public int? Year { get; set; }
        
        [BsonElement("score")]
        public double? SearchScore { get; set; } = null;
    }
}