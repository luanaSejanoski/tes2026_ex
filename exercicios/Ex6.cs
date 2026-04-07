using System;
    public class Ex6
    {
        public static void Executar()
        {
        Console.WriteLine("Digite um numero: ");
        int num = int.Parse(Console.ReadLine());

        for(int i = 0; i <= 10; i++){
        int resul = num * i;
        Console.WriteLine($"{num} x {i} = {resul}");
}
        }
    }