using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace CommandsAPIMongo.Models
{
    public class Command
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "HowTo")]
        [BsonElement("HowTo")]
        public string HowTo { get; set; }

        [JsonProperty(PropertyName = "Platform")]
        [BsonElement("Platform")]
        public string Platform { get; set; }

        [JsonProperty(PropertyName = "CommandLine")]
        [BsonElement("CommandLine")]
        public string CommandLine { get; set; }
    }
}

