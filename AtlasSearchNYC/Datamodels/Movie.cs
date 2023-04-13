using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AtlasSearchNYC.Datamodels
{
    [BsonIgnoreExtraElements]
    class Movie {
        public ObjectId _id {get;set;}
        public string title { get; set; }
        public string fullplot { get; set; }
    }
}