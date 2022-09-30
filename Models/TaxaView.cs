using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JurosReal.Models
{
    public class TaxaView
    {
        [JsonPropertyName("nome")]
        public string NomeTaxa { get; set; }

        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
}