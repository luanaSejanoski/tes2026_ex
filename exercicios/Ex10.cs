using System;

    public class Ex10
    {
        public static bool EhPar(int n){
         if(n % 2 == 0){
             return true;
         }else{
            return false;
        }
    }
        public static void Executar()
        {
         Console.WriteLine(EhPar(5));
    }
}
