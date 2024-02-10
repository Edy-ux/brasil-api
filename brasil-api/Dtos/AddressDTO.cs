using System.Text.Json.Serialization;

namespace brasil_api.Dtos
{
    public class AddressDTO
    {

        public string? Cep { get; set; }

        public string? Estado { get; set; }
 
        public string? Cidade { get; set; }
        public string? Regiao { get; set; }

        public string? Rua { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }
}
