using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AtlasSearchNYC.Datamodels
{
    [BsonIgnoreExtraElements]
    public class Highlight {
        [BsonElement("path")]
        public string Path { get; set; }
        
        [BsonElement("score")]
        public double? SearchScore { get; set; } = null;
        [BsonElement("texts")]
        public List<HighlightText> Texts {get;set;} = new List<HighlightText>();
    }

    [BsonIgnoreExtraElements]
    public class HighlightText {
        [BsonElement("type")]
        public string ReasonForSplit { get; set; }
        [BsonElement("value")]
        public string Section { get; set; }
        
    }
}