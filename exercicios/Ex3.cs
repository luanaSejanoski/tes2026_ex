using System;
    public class Ex3
    {
        public static void Executar()
        {
        Console.WriteLine("Digite o primeiro numero: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        float num2 = float.Parse(Console.ReadLine());

        float soma = num1 + num2;
        float sub = num1 - num2;
        float multi = num1 * num2;
        float div = num1 / num2;

        Console.WriteLine($"Soma: {soma}\nSubtração: {sub}\nMultiplicação: {multi}\nDivisão: {div}");
    }
}