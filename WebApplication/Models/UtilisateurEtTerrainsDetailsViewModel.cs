﻿using Fr.EQL.Ai109.Tontapatt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fr.EQL.Ai109.Tontapatt.WebApplication.Models
{
    public class UtilisateurEtTerrainsDetailsViewModel
    {
        public List<TerrainDetails> TerrainsDetails { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
