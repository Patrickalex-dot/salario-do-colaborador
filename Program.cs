using System;

namespace salario_do_colaborador
{
    class Program
    {
        static void Main(string[] args)
            
        {
            decimal salario;
            decimal salarioEmDolar;
            decimal salarioEmEuro;

            Console.WriteLine("Digite o salário do colaborador");
            salario = Convert.ToDecimal(Console.ReadLine());

            if (salario < 1200)
            {
                Console.WriteLine("valor total do acrescimo: " + salario * 20 / 100);

            }
            if (salario >= 1200 && salario < 2000) 
            {
                Console.WriteLine("valor total do acrescimo: " + salario * 13 / 100);
            }
            if (salario > 2000 && salario < 2500)
            {
                Console.WriteLine("valor total do acrescimento: " + salario * 10 / 100);
            }
            else if (salario > 2500)
            {
                Console.WriteLine("valor total do acrescimo: " + salario * 5 / 100);
            }

            salarioEmDolar = salario / 4.70M;
            Console.WriteLine("O salario em dolar é: " + salarioEmDolar);

            salarioEmEuro = salario / 5.20M;
            Console.WriteLine("O salario em euro é: " + salarioEmEuro);
        }
    }
}
