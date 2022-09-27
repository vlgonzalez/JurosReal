using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace JurosReal.Models
{
    public class TaxaDeJuros
    {   
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("valor")]
        public double Valor { get; set; }
        
    }
}