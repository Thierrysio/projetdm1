using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetdm1.Modeles
{
    public class Categorie
    {
        #region attributs
        private int id;
        private string nom;
        private CategorieParent lacategorieParent;
        #endregion

        #region constructeurs
        public Categorie(int id, string nom, CategorieParent lacategorieParent)
        {
            this.id = id;
            this.nom = nom;
            this.lacategorieParent = lacategorieParent;
        }
        #endregion

        #region getters/setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("nom")]
        public string Nom { get => nom; set => nom = value; }

        [JsonProperty("lacategorieParent")]
        public CategorieParent LacategorieParent { get => lacategorieParent; set => lacategorieParent = value; }
        #endregion

        #region methodes

        #endregion
    }
}
