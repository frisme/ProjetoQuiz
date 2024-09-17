namespace ProjetoQuiz;

public partial class GamePage : ContentPage
{
	Questao questao;

	
    public GamePage()
    {
        InitializeComponent();
        Desenhar();
        questao.Question ="Qual é o maior oceano do planeta Terra?";
    }
    public void Desenhar()
    {
        LabelQuestion.Text = questao.Question;
    }
}