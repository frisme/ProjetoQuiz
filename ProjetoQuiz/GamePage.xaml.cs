namespace ProjetoQuiz;

public partial class GamePage : ContentPage
{
    public GamePage()
    {
        InitializeComponent();
    }

    // Evento de clique das respostas
    private void OnRespostaClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        // Simular a verificação da resposta correta (você pode alterar para lógica real)
        if (button.Text == "Resposta Correta")
        {
            DisplayAlert("Correto!", "Você acertou!", "OK");
        }
        else
        {
            DisplayAlert("Errado!", "Tente novamente!", "OK");
        }
    }
}
