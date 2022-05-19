using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class AtorFilme
    {
        public AtorFilme(int atorId, int filmeId)
        {
            AtorId = atorId;
            FilmeId = filmeId
        }

        public int AtorId { get; set; }
        public Ator Ator { get; set; }

        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
    }
}
