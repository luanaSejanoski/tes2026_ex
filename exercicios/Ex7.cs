using System;

    public class Ex7
    {
        public static void Executar()
        {
        float total = 0;
        float media = 0;

       for(int i = 1; i <= 5; i++){
       Console.WriteLine("Digite um numero: ");
       float num = float.Parse(Console.ReadLine());
       total += num;
}
       media = total / 5.0f;
       Console.WriteLine($"Total: {total}\nMédia: {media}");
        }
    }
