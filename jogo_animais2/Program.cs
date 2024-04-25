using jogo_animais2;

class Program

{
    static void Main()
    {
        Animal hipo = new Animal();
        Animal zebra = new Animal();
        Animal leao = new Animal();
        Personagem barco = new Personagem();

        Console.WriteLine("Seja bem-vindo ao jogo dos animais!");
        Console.WriteLine("Objetivo: atravessar o rio com os animais e terminar o jogo com todos a salvo.");
        Console.WriteLine("Regras: Atravessar o rio com um animal de cada vez.");
        Console.WriteLine("Os animais trocam de lado se movimentando com o barco, se o guarda estiver com o barco no mesmo lado do rio os animais ainda estão a salvo");
        Console.WriteLine("Se o hipopótamo for deixado sozinho com o leão, ele comerá o leão.");
        Console.WriteLine("Se o leão for deixado sozinho com a zebra, ele comerá a zebra.");

        while (hipo.estaDoLadoDireito || leao.estaDoLadoDireito || zebra.estaDoLadoDireito || barco.estaDoLadoDireito)
        {
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("Início de jogo: Todos os animais começam no lado direito do rio.");
            Console.WriteLine("Escolha um animal para entrar no barco e atravessar para o lado esquerdo do rio:");
            Console.WriteLine(" H. Hipopótamo  L. Leão   Z. Zebra   0. Sair");
            string animalEscolhido = Console.ReadLine().ToUpper();

            switch (animalEscolhido)
            {
                case "H":
                    Console.WriteLine("Game Over! Você deixou o leão com a zebra");
                    break;
                case "L":
                    leao.estaDoLadoEsquerdo = true;
                    barco.estaDoLadoEsquerdo = true;
                    Console.WriteLine("Boa jogada! Todos animais continuam vivos, e o leão está do lado esquerdo.");
                    break;
                case "Z":
                    Console.WriteLine("Game Over! Você deixou o Hipopotámo com a zebra");
                    break;
                case "0":
                    Console.WriteLine("Você saiu do jogo.");
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }

            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("Bem-vindo à segunda fase:");
            Console.WriteLine("O guarda retornou com o barco vazio. Agora escolha o próximo animal para ir para o lado esquerdo:");
            Console.WriteLine("H");
            Console.WriteLine("Z");
            Console.WriteLine("0. Sair");
            string segundoAnimalEscolhido = Console.ReadLine().ToUpper();
            string animalQueSobrou = string.Empty;

            switch (segundoAnimalEscolhido)
            {
                case "H":
                    hipo.estaDoLadoEsquerdo = true;
                    barco.estaDoLadoEsquerdo = true;   // descobrir qual animal fica no lado direito
                    animalQueSobrou = "Z";
                    Console.WriteLine("Todos os animais estão vivos. Mas atente-se a regras do jogo.");
                    break;
                case "Z":
                    zebra.estaDoLadoEsquerdo = true;
                    barco.estaDoLadoEsquerdo = true;
                    Console.WriteLine("Todos os animais estão vivos. Mas atente-se a regras do jogo.");
                    animalQueSobrou = "H";
                    break;
                case "0":
                    Console.WriteLine("Você saiu do jogo.");
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }
            while (hipo.estaDoLadoDireito || zebra.estaDoLadoDireito)
            {
                Console.WriteLine("______________________________________________________________________________________________________");
                Console.WriteLine("Bem-vindo à terceira fase:");
                Console.WriteLine("Escolha o animal para voltar ao lado direito com o guarda no barco:");
                Console.WriteLine("L");
                Console.WriteLine(segundoAnimalEscolhido.ToString());
                Console.WriteLine("0. Sair");
                string terceiroAnimalEscolhido = Console.ReadLine().ToUpper();

                switch (terceiroAnimalEscolhido)
                {
                    case "H":
                        hipo.estaDoLadoDireito = true;
                        barco.estaDoLadoDireito = true;
                        Console.WriteLine("Todos os animais continuam vivos, mas sua jogada não fez nenhuma alteração no jogo, tente novamente.");
                        break;
                    case "Z":
                        zebra.estaDoLadoDireito = true;
                        barco.estaDoLadoDireito = true;
                        Console.WriteLine("Todos os animais continuam vivos, mas sua jogada não fez nenhuma alteração no jogo, tente novamente.");
                        break;
                    case "L":
                        hipo.estaDoLadoDireito = false;
                        zebra.estaDoLadoDireito = false;
                        leao.estaDoLadoDireito = true;
                        barco.estaDoLadoDireito = true;
                        Console.WriteLine("Todos os animais continuam vivos. E agora o Leão está do lado direito.");
                        break;
                    case "0":
                        Console.WriteLine("Você saiu do jogo.");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        break;
                }

                Console.WriteLine("______________________________________________________________________________________________________");
                Console.WriteLine("Bem-vindo à quarta fase:");
                Console.WriteLine("Escolha o animal para ir para o lado esquerdo com o guarda no barco:");
                Console.WriteLine("L");
                Console.WriteLine(animalQueSobrou);
                Console.WriteLine("0. Sair"); 
                string quartoAnimalEscolhido = Console.ReadLine().ToUpper();
            }
            
        }
    }
}














