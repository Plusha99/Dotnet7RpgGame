using System.Text.Json.Serialization;

namespace Dotnet7RpgGame.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Hiller = 3
    }
}