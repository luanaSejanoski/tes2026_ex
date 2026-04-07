using System;

    public class Ex4
    {
        public static void Executar()
        {
      Console.WriteLine("Informe a sua idade: ");
      int idade = int.Parse(Console.ReadLine());

      if(idade < 18){
        Console.WriteLine("Menor de idade");      
      }else{
        Console.WriteLine("Maior de idade");
    }
    }
}
