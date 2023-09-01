using System.Text.Json.Serialization;

namespace WebAPiS.Enums
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum

    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
