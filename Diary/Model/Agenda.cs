using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Diary.Model
{
    public class Agenda 
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public int Telefone { get; set; }
        public int Idade { get; set; } 

        [JsonProperty ("cep")]
        public int Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }        


    }
}
