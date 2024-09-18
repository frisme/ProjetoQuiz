using ProjetoQuiz;

public class Gerenciador
{
    List <Questao> listaQuestoes = new Lista<Questao>();
    List <int> listaQuestoesRespondidas = new Lista <int>();
    Questao questaoCorrente;
    public Gerenciador(Label labelPergunta,Button binResp01,Button binResp02,Button binResp03,Button binResp04,Button binResp05)
{
    CriarQuestoes (labelPergunta, binResp01, binResp02, binResp03, binResp04, binResp05);
}

}