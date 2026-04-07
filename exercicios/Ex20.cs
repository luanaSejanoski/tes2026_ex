using System;

    public class Ex20
    {
        public static void Executar()
        {
          int[] numeros = new int[5];
          float media = 0;

          for(int i = 0; i < numeros.Length; i++){
            Console.WriteLine($"Digite o numero da posição {i} do vetor: ");
            numeros[i] = int.Parse(Console.ReadLine());
            media += numeros[i] / 5f;
          }
            Console.Write($"Média: {media} ");
        }
}
