using Microsoft.Maui.Storage; // Importante para salvar dados localmente

namespace ContadorApp
{
    public partial class MainPage : ContentPage
    {
        int contador1 = 0;
        int contador2 = 0;

        public MainPage()
        {
            InitializeComponent();

            // Carregar os últimos valores salvos
            if (Preferences.ContainsKey("contador1"))
            {
                contador1 = Preferences.Get("contador1", 0);
                contadorLabel1.Text = contador1.ToString();
            }

            if (Preferences.ContainsKey("contador2"))
            {
                contador2 = Preferences.Get("contador2", 0);
                contadorLabel2.Text = contador2.ToString();
            }
        }

        private void OnIncrementClicked1(object sender, EventArgs e)
        {
            contador1++;
            AtualizarContador();
        }

        private void OnDecrementClicked1(object sender, EventArgs e)
        {
            contador1--;
            AtualizarContador();
        }

        private void OnIncrementClicked2(object sender, EventArgs e)
        {
            contador2++;
            AtualizarContador();
        }

        private void OnDecrementClicked2(object sender, EventArgs e)
        {
            contador2--;
            AtualizarContador();
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            contador1 = 0;
            contador2 = 0;
            AtualizarContador();
        }

        private void AtualizarContador()
        {
            contadorLabel1.Text = contador1.ToString();
            contadorLabel2.Text = contador2.ToString();
            Preferences.Set("contador1", contador1); // Salvar o valor
            Preferences.Set("contador2", contador2);
        }
    }
}
