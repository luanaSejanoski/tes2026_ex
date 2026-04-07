using System;

    public class Ex2
    {
       public static void Executar()
        {
        Console.WriteLine("Digite um numero inteiro: ");
        int num = int.Parse(Console.ReadLine());
        int resul = num * 2;
        Console.WriteLine($"O dobro de {num} é: {resul}");
    }
}
