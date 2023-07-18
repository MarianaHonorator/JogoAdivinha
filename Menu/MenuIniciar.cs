using System.Data;
using System.Xml;

namespace JogoAdivinha.Menu;


internal class MenuIniciar
{
     private static int respostaNumb;

    public static void IniciandoJogo()
    {   
        int contador = 10;
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101);
        int valorNumb = Convert.ToInt32(valorInteiro);
        Console.WriteLine(valorInteiro);
        

        do
        {
            Console.WriteLine($"\n Tentativas [{contador}]\n");
            Console.Write(" Qual o número sorteado? ");
            string respostaString = Console.ReadLine()!;
            respostaNumb = Convert.ToInt32(respostaString);

            if (respostaNumb != valorNumb)
            {

                if (respostaNumb < valorInteiro)
                {
                    Console.WriteLine($" Errou!!! {respostaNumb} é menor que o valor sorteado");
                }
                if(respostaNumb > 100)
                {
                    Console.WriteLine("O número digitado não está entre o intervalo de 1 a 100. Tente Novamente!");
                    contador++;
                }
                else if ((respostaNumb > valorInteiro) && !(respostaNumb > 100))
                {
                    Console.WriteLine($" Errou!!! {respostaNumb} é maior que o valor sorteado");
                }


            }
            contador--;
        } while (respostaNumb != valorNumb && contador != 0);

        if (respostaNumb == valorNumb)
        {
            Console.WriteLine("\n PARÁBENS VOCÊ ACERTOU!!");
            Console.WriteLine(" Voltando ao Menu....");
            Thread.Sleep(5000);
            Console.Clear();
        }

        else if (respostaNumb != valorNumb)
        {
            Console.WriteLine("\n VOCÊ PERDEU!!");
            Console.WriteLine(" Voltando ao Menu....");
            Thread.Sleep(5000);
            Console.Clear();
        

        }
        
    }
}
