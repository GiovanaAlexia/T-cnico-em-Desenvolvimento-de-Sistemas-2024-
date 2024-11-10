using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
       
        public List<quarto> lista_quartos = new List<quarto>
        {
            new quarto()
            {
                Descricao = "Quarto Executivo",
                ValorDiariaAdulto=1200.0,
                ValorDiariaCrianca=600.0
            },
            new quarto()
            {
                Descricao = "Quarto Elite",
                ValorDiariaAdulto=700.0,
                ValorDiariaCrianca=350.0
            },
            new quarto()
            {
                Descricao = "Quarto Padrão",
                ValorDiariaAdulto=400.0,
                ValorDiariaCrianca=200.0
            },
            new quarto()
            {
                Descricao = "Quarto Individual",
                ValorDiariaAdulto=300.0,
                ValorDiariaCrianca=150.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.paginaInicial());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
