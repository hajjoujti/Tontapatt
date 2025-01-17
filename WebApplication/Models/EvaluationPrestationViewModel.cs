﻿using Fr.EQL.Ai109.Tontapatt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fr.EQL.Ai109.Tontapatt.WebApplication.Models
{
    public class EvaluationPrestationViewModel
    {
        public int IdUtilisateurClient { get; set; }
        public int IdUtilisateurEleveur { get; set; }
        public int IdDemande { get; set; }
        public int NotePrestation { get; set; }
        public string RemarqueEval { get; set; }
        public DemandeDeReservationDetails DemandeDeReservationDetails { get; set; }
        public int IdUtilisateur { get; set; }
        public int IdUtilisateurEvaluateur { get; set; }
        public List<EvaluationPrestation> EvaluationsPrestation { get; set; }
    }
}
