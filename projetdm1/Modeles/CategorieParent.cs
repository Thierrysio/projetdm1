﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetdm1.Modeles
{
    public class CategorieParent
    {
        #region attributs
        private int id;
        private string nom;
        #endregion

        #region constructeurs
        public CategorieParent(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        #endregion

        #region getters/setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("nom")]
        public string Nom { get => nom; set => nom = value; }
        #endregion

        #region methodes

        #endregion
    }
}
