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
        float subtracao = num1 - num2;
        float multiplicacao = num1 * num2;
        float divisao = num1 / num2;

        Console.WriteLine($"Soma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}");
    }
}