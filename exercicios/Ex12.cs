using System;

    public class Ex12
    {
        public static double Media(double a, double b, double c){
         double media = (a + b + c) / 3.0;
         return media;
    }
        public static void Executar()
        {
         Console.WriteLine($"{Media(2, 9, 5):F2}");
    }
}
