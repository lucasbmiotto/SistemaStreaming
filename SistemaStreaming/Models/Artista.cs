using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Artista : IEntidade
    {
        public int id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string FotoPerfilURL { get; set; }
    }
}
