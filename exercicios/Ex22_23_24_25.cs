using System;

enum Menu{
    Adicionar = 1,
    Remover = 2,
    Escolher = 3,
    Sair = 4
}


    public class Ex22_23_24_25
    {

         public static void AdicionarCarro(List<Carro> carros){
         string continuar = "s";

         while(continuar == "s"){
            Carro c = new Carro();
            Console.WriteLine("Marca: ");
            c.marca = Console.ReadLine();

            Console.WriteLine("Modelo: ");
            c.modelo = Console.ReadLine();

            Console.WriteLine("Ano: ");
            c.ano = int.Parse(Console.ReadLine());

            carros.Add(c);

            Console.WriteLine("Continuar? (s/n): ");
            continuar = Console.ReadLine().ToLower();

         }
        }

          public static void RemoverCarro(List<Carro> carros){
           
           if(carros.Count == 0){
            Console.WriteLine("Não há carros para remover!!\nPressione ENTER para voltar ao menu");
            Console.ReadLine();
            return;
           }
            for(int i = 0; i < carros.Count; i++){
            Console.WriteLine($"índice {i}:");
            carros[i].ExibirDados();
            }

             Console.Write("\nEscolha o índice do carro que deseja remover: ");
            int escolha = int.Parse(Console.ReadLine());

            if(escolha >= 0 && escolha < carros.Count){
            carros.RemoveAt(escolha);
            Console.WriteLine("Carro removido com sucesso!");
           }else{
            Console.WriteLine("Índice inválido");
           }  
         }

         public static void EscolherCarro(List<Carro> carros){

           if(carros.Count == 0){
            Console.WriteLine("Não há carros para escolher!\nPressione ENTER para voltar ao menu");
            Console.ReadLine();
            return;
           }

             for(int i = 0; i < carros.Count; i++){
            Console.WriteLine($"índice {i}:");
            carros[i].ExibirDados();
           }
           Console.Write("\nEscolha um carro pelo índice: ");
           int escolha = int.Parse(Console.ReadLine());
      

           if(escolha >= 0 && escolha < carros.Count){
            Carro carroEscolhido =  carros[escolha];
            Console.WriteLine("Carro escolhido:\n");
            carroEscolhido.ExibirDados();
           }else{
            Console.WriteLine("Índice inválido");
           } 
         }
      
      public static float media(Carro[] garagem){
        float soma = 0;
        for(int i = 0; i < garagem.Length; i++){
            soma += garagem[i].ano;
        }
        return soma / garagem.Length;
      }

        public static void Executar()

        {
            Carro[] garagem = new Carro[3];
     

            for(int i = 0; i < garagem.Length; i++){
               garagem[i] = new Carro();
               Console.WriteLine("Digite a marca do carro: ");
               garagem[i].marca = Console.ReadLine();
               Console.WriteLine("Digite o modelo do carro: ");
               garagem[i].modelo = Console.ReadLine();
               Console.WriteLine("Digite o ano do carro: ");
               garagem[i].ano = int.Parse(Console.ReadLine());
            
            }
            
            foreach(Carro c in garagem){
                c.ExibirDados();
            }
           
           Console.WriteLine($"Média dos anos dos carros: {media(garagem):F2}");

           List<Carro> carros = new List<Carro>(garagem);
          
           bool rodando = true;

        while(rodando){
        Console.WriteLine("----MENU----\n1-Adicionar\n2-Remover\n3-Escolher\n4-Sair\n");
        int escolha = int.Parse(Console.ReadLine());
        switch((Menu)escolha){
            case Menu.Adicionar:
             AdicionarCarro(carros);
            break;
            case Menu.Remover:
             RemoverCarro(carros);
            break;
            case Menu.Escolher:
             EscolherCarro(carros);
            break;
            case Menu.Sair:
             Console.WriteLine("Programa encerrado!");
             rodando = false;
             break;
            default:
             Console.WriteLine("Opção inválida!");
            break;
             
        }
        }
        
          
    }

    }

   
    



