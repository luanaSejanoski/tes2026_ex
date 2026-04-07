using System;

        public class Funcionario{
            public string nome;
            public double salario;
            public string cargo;


        public void ExibirDados(){
            Console.WriteLine($"Nome: {nome}\nSalário: R${salario}\nCargo: {cargo}\n----------------------------------");
        }
        public double CalcularSalarioAnual(double salario){
           double salarioAnual = salario * 12;
            return salarioAnual;
        }
        public double AumentarSalario(double percentual){
         salario += salario * (percentual / 100);
         return salario;
        }
        public double DescontarSalario(double valor){
             if(valor > salario){
               salario = 0;
            } else {
               salario -= valor;
            }
               return salario;
        }
        }
        public class Ex13_14_15_16_17
    {
       
        public static void Executar()
        {
         Carro c1 = new Carro();
         c1.marca = "Chevrolet";
         c1.modelo = "Impala 67";
         c1.ano = 1967;

         c1.ExibirDados();

         Funcionario f1 = new Funcionario();
         f1.nome = "Rogério";
         f1.salario = 5000;
         f1.cargo = "Mecânico";

         f1.ExibirDados();
         Console.WriteLine($"Salario Anual: R${f1.CalcularSalarioAnual(f1.salario)}");
         Console.WriteLine($"Aumento de salario para: R${f1.AumentarSalario(10)}");
         Console.WriteLine($"Salario Anual: R${f1.CalcularSalarioAnual(f1.salario)}");

         Console.WriteLine($"Salário reduzido para: R${f1.DescontarSalario(1000)}");
         Console.WriteLine($"Salario Anual: R${f1.CalcularSalarioAnual(f1.salario)}");
         }
}
