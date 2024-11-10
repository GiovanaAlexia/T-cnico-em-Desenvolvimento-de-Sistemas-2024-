namespace MauiAppHotel.Views;

public partial class paginaInicial : ContentPage
{
	public paginaInicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ContratacaoHospedagem());
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}