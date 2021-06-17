﻿using Fr.EQL.Ai109.Tontapatt.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.Ai109.Tontapatt.DataAccess
{
    public  class MoyenPaiementDAO : DAO
    {
        public List<TypeAnomalie> GetAll()
        {
            List<TypeAnomalie> moyensPaiement = new();
            MySqlCommand cmd = CreerCommand();
            cmd.CommandText = @"SELECT *
                                FROM moyenpaiement";
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TypeAnomalie moyenPaiement = new();
                moyenPaiement.IdMoyenPaiment = dr.GetInt32("id_moyen_paiement");
                moyenPaiement.TypeMoyenPaiement = dr.GetString("type_moyen_paiement");
                moyensPaiement.Add(moyenPaiement);
            }

            cmd.Connection.Close();
            return moyensPaiement;
        }
    }
}
