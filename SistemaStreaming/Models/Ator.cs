using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Ator : Artista
    {
        public List<AtorFilme> AtoresFilmes { get; set; }
    }
}