using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class FilmeCategoria
    {
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
