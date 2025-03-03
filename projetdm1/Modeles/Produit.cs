using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetdm1.Modeles
{
    public class Produit
    {
        #region attributs
        private int id;
        private string nomProduit;
        private string description;
        private double prix;
        private int quantiteDisponible;
        private List<Commande> lesCommandes;
        private Categorie laCategorie;
        private string descriptioncourte;
        private int etoiles;
        private int nbvotes;
        private int nbAvis;
        private int points;
        private string dateCreation;
        #endregion

        #region constructeurs
        public Produit(int id, string nomProduit, string description, double prix, int quantiteDisponible, Categorie laCategorie, string descriptioncourte, int etoiles, int nbvotes, int nbAvis, int points, string dateCreation)
        {
            this.id = id;
            this.nomProduit = nomProduit;
            this.description = description;
            this.prix = prix;
            this.quantiteDisponible = quantiteDisponible;
            this.lesCommandes = new List<Commande>();
            this.laCategorie = laCategorie;
            this.descriptioncourte = descriptioncourte;
            this.etoiles = etoiles;
            this.nbvotes = nbvotes;
            this.nbAvis = nbAvis;
            this.points = points;
            this.dateCreation = dateCreation;
        }
        #endregion

        #region getters/setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("nomProduit")]
        public string NomProduit { get => nomProduit; set => nomProduit = value; }

        [JsonProperty("description")]
        public string Description { get => description; set => description = value; }

        [JsonProperty("prix")]
        public double Prix { get => prix; set => prix = value; }

        [JsonProperty("quantiteDisponible")]
        public int QuantiteDisponible { get => quantiteDisponible; set => quantiteDisponible = value; }

        [JsonProperty("lesCommandes")]
        public List<Commande> LesCommandes { get => lesCommandes; set => lesCommandes = value; }

        [JsonProperty("laCategorie")]
        public Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }

        [JsonProperty("descriptioncourte")]
        public string Descriptioncourte { get => descriptioncourte; set => descriptioncourte = value; }

        [JsonProperty("etoiles")]
        public int Etoiles { get => etoiles; set => etoiles = value; }

        [JsonProperty("nbvotes")]
        public int Nbvotes { get => nbvotes; set => nbvotes = value; }

        [JsonProperty("nbAvis")]
        public int NbAvis { get => nbAvis; set => nbAvis = value; }

        [JsonProperty("points")]
        public int Points { get => points; set => points = value; }

        [JsonProperty("dateCreation")]
        public string DateCreation { get => dateCreation; set => dateCreation = value; }
        #endregion

        #region methodes

        #endregion
    }
}
