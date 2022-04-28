using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialize
{
    class Dados
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Proficao { get; set; }

        public string JsonSerializar(Dados dados)
        {
            return JsonConvert.SerializeObject(dados);
        }

        public static Dados JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Dados>(Json);
        }
    }
}
