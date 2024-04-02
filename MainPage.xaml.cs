using Microsoft.Maui.Controls.Shapes;

namespace atividadeavaliativa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Botao_Clicked(object sender, EventArgs e)
        {
            Random num = new Random();
            valueEntry.Text = num.Next(0, 6).ToString();
        }
    }
}
