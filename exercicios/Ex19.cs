using System;

    public class Ex19
    {
       public static void Executar()
        {
          int[] numeros = new int[5];
          int maior = 0;

          for(int i = 0; i < numeros.Length; i++){
            Console.WriteLine($"Digite o numero da posição {i} do vetor: ");
            numeros[i] = int.Parse(Console.ReadLine());
          }

          for(int i = 0; i < numeros.Length; i++){
            if(numeros[i] > maior){
                maior = numeros[i];
            }
          }
            Console.Write($"Maior número: {maior} ");
        }
}


