﻿using System.Text.Json.Serialization;

namespace brasil_api.Models
{
    public class AddressModel
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? Estado    { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Regiao { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
