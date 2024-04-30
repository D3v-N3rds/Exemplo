// Um delegado para o evento que dispara quando o jogo é ligado
public delegate void LigarJogoHandler();

// O Controlador
public class Controlador
{
    public event LigarJogoHandler OnLigarJogo;

    public Controlador()
    {
        // O controlador vai decidir o que acontece quando o jogo é ligado
        OnLigarJogo += PromptNomeJogador;
    }

    private void PromptNomeJogador()
    {
        // Aqui o Controlador diz à view para pedir o nome do jogador
        Console.WriteLine("Por favor, Introduza o nome de Jogador: ");
    }

    public void LigarJogo()
    {
        // O sinal para ligar o jogo
        OnLigarJogo?.Invoke();
    }
}

// A View
public class View
{
    private Controlador controlador;

    public View(Controlador controlador)
    {
        this.controlador = controlador;
    }

    public void MostraTelaInicial()
    {
        // Lógica para mostrar a tela inicial do jogo
        // Quando pronta, diz ao controlador para iniciar o jogo
        controlador.LigarJogo();
    }
}

// O Jogador
public class Jogador
{
    private View view;
    
    public Player(View view)
    {
        this.view = view;
    }

    public void BotaoLigarJogo()
    {
        // A ação do jogador que começa tudo
        view.MostraTelaInicial();
    }
}
