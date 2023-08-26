using System.Text.Json.Serialization;

namespace WebAPiS.Enums
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurmoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
