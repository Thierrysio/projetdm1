using projetdm1.Modeles;
using projetdm1.Services;
using System.Collections.ObjectModel;

namespace projetdm1.Vues;

public partial class VueProduits : ContentPage
{
    #region attributs
    private readonly Apis _apiService = new Apis();
    public ObservableCollection<Produit> Produits { get; set; }

    #endregion
    #region constructeur
    public VueProduits()
	{
        InitializeComponent();
        Produits = new ObservableCollection<Produit>();
        BindingContext = this;
        LoadProduits();

    }
    #endregion
    #region methodes
    private async void LoadProduits()
    {
        try
        {
            var produits = await _apiService.GetAllAsync<Produit>("api/mobile/GetLesProduites");
            foreach (var produit in produits)
            {
                Produits.Add(produit);
            }
        }
        catch (Exception ex)
        {
            // Gérer l'exception (par exemple, afficher un message d'erreur)
            await DisplayAlert("Erreur", "Impossible de charger les produits.", "OK");
        }
    }
    #endregion
}