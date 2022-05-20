﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Ator : Artista
    {
        public Ator(int id, string nome, string bio, string fotoPerfilURL) : base(id, nome, bio, fotoPerfilURL)
        {
        }

        public List<AtorFilme> AtoresFilmes { get; set; }
    }
}