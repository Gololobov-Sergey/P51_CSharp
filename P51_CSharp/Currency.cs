using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace P51_CSharp
{
    public class Currency
    {
        [JsonPropertyName("r030")]
        public int Code { get; set; }


        [JsonPropertyName("txt")]
        public string Name { get; set; }


        [JsonPropertyName("rate")]
        public decimal Rate { get; set; } 


        [JsonPropertyName("cc")]
        public string TxtCode { get; set; }


        [JsonPropertyName("exchangedate")]
        public string ExchangeDate { get; set; }


        [JsonPropertyName("special")]
        public string Special { get; set; }


        public Currency()
        {
            
        }

        public override string ToString()
        {
            return $"{Code} {Name} {Rate}";
        }

    }
}
