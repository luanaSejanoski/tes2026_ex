using System;

    public class Ex11
    {
        public static int Maior(int a, int b){
         if(a > b){
             return a;
         }else{
            return b;
        }
    }
        public static void Executar()
        {
         Console.WriteLine(Maior(5, 9));
    }
}
