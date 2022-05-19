using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Categoria : IEntidade
    {
        public int id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
        public List<FilmeCategoria> FilmeCategorias { get; set; }
    }
}
