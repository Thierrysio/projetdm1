using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetdm1.Modeles
{
    public class Commande
    {
        #region attributs
        private int id;
        private int quantite;
        private double prixretenu;
        private bool noteDonnee;
        #endregion

        #region constructeurs
        public Commande(int id, int quantite, double prixretenu, bool noteDonnee)
        {
            this.id = id;
            this.quantite = quantite;
            this.prixretenu = prixretenu;
            this.noteDonnee = noteDonnee;
        }
        #endregion

        #region getters/setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("quantite")]
        public int Quantite { get => quantite; set => quantite = value; }

        [JsonProperty("prixretenu")]
        public double Prixretenu { get => prixretenu; set => prixretenu = value; }

        [JsonProperty("noteDonnee")]
        public bool NoteDonnee { get => noteDonnee; set => noteDonnee = value; }
        #endregion

        #region methodes

        #endregion
    }
}
