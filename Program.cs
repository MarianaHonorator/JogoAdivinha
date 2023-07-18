using JogoAdivinha.Menu;


        Dictionary<int, Action> methodDictionary = new Dictionary<int, Action>();
        methodDictionary[1] = MenuIniciar.IniciandoJogo;
        methodDictionary[2] = ExibindoDetalhesJogo.ExibindoDetalhes;
        methodDictionary[3] = MenuSair.MenuSaindo;

        void MensagemBoasVindas()
        {
            Console.WriteLine(@"
░░░▒█ ▒█▀▀▀█ ▒█▀▀█ ▒█▀▀▀█ 　 ▒█▀▀▄ ░█▀▀█ 　 ░█▀▀█ ▒█▀▀▄ ▀█▀ ▒█░░▒█ ▀█▀ ▒█▄░▒█ ▒█░▒█ ░█▀▀█ ▒█▀▀█ ░█▀▀█ ▒█▀▀▀█ 
░▄░▒█ ▒█░░▒█ ▒█░▄▄ ▒█░░▒█ 　 ▒█░▒█ ▒█▄▄█ 　 ▒█▄▄█ ▒█░▒█ ▒█░ ░▒█▒█░ ▒█░ ▒█▒█▒█ ▒█▀▀█ ▒█▄▄█ ▒█░░░ ▒█▄▄█ ▒█░░▒█ 
▒█▄▄█ ▒█▄▄▄█ ▒█▄▄█ ▒█▄▄▄█ 　 ▒█▄▄▀ ▒█░▒█ 　 ▒█░▒█ ▒█▄▄▀ ▄█▄ ░░▀▄▀░ ▄█▄ ▒█░░▀█ ▒█░▒█ ▒█░▒█ ▒█▄▄█ ▒█░▒█ ▒█▄▄▄█");

            Console.WriteLine("\n Bem-vindo ao Jogo da Adivinhação!\n");
        }


        void OpcoesMenu()
        {
            MensagemBoasVindas();
            Console.WriteLine(" Escolha uma das seguintes opções");
            Console.WriteLine(" 1 - Iniciar jogo");
            Console.WriteLine(" 2 - Ler regras do jogo");
            Console.WriteLine(" 3 - Sair do jogo");
            Console.Write("\n > ");

            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (methodDictionary.ContainsKey(opcaoEscolhidaNumerica))
            {

                Action action = methodDictionary[opcaoEscolhidaNumerica];
                action.Invoke();
                if (opcaoEscolhidaNumerica > 0 && opcaoEscolhidaNumerica != 3) OpcoesMenu();
             }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

       
        OpcoesMenu();
    
