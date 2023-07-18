namespace JogoAdivinha.Menu;

internal class ExibindoDetalhesJogo 
{
	 public static void ExibindoDetalhes()
	{
        Console.Clear();
        Console.WriteLine("\n O jogador tem 10 tentativas para acertar o número sorteado, caso o número de tentativas chegue a 0, você *PERDE!*");
        Console.WriteLine("\n Aperte uma tecla para voltar ao Menu");
        Console.ReadKey();
        Console.Clear();
        

    }
}
