using System;
    public class Ex5
    {
        public static void Executar()
        {
      Console.WriteLine("Informe um número: ");
      int numero = int.Parse(Console.ReadLine());

      if(numero > 0){
         Console.WriteLine($"{numero} é positivo");
       }else if(numero < 0){
         Console.WriteLine($"{numero} é negativo");
       }else{
         Console.WriteLine("Zero");
    }
}
   }
