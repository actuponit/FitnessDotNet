using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace FitnessDotNet.User
{
    public enum Gender {
        Male,
        Female
    }
    public class User{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id{ get; set; }
        
        public string? Fname { get; set; }
        
        public string? Lname { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public Gender? Gender { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }

}