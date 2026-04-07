using System;

    public class Ex18
    {
        public static void Executar()
        {
          int[] numeros = new int[5];

          for(int i = 0; i < numeros.Length; i++){
            Console.WriteLine($"Digite o numero da posição {i} do vetor: ");
            numeros[i] = int.Parse(Console.ReadLine());
          }
          for(int i = 0; i < numeros.Length; i++){
            Console.Write($"{numeros[i]} ");
          }
        }
}
