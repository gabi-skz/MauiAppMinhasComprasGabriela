namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
    public ListaProduto()
    {
        InitializeComponent();
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e) //no item clicado oq acontece
    {
        try
        {
            Navigation.PushAsync(new Views.NovoProduto()); //fazendo a navega��o entre as telas, a lista de produtos com a pagina novo produto

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}