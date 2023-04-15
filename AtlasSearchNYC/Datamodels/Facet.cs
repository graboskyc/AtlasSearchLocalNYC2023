using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AtlasSearchNYC.Datamodels
{
    [BsonIgnoreExtraElements]
    public class FacetResponse {
        [BsonElement("genresFacetBuckets")]
        public List<FacetBucket> Genres { get; set; }
        [BsonElement("castFacetBuckets")]
        public List<FacetBucket> Cast { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class FacetBucket {
        [BsonElement("_id")]
        public string Key { get; set; }
        [BsonElement("count")]
        public int Count { get; set; }
    }
}