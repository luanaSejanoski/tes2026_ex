using System;

    public class Ex8
    {
        public static void Executar()
        {
            int num = 1;
            int total = 0;

        while(num != 0){
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        total += num;
}
        Console.WriteLine($"Total: {total}");
        }
    }
