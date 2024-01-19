using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var texto = "Testando.";
            // decimal salario = 2.500m;
            // bool buli = false;
            // char sexo = 'M';
            // string nome = "Anthony";
            // var idade = 18;
            // var nome1 = "André";
            // object idade = 25;
            // int? tamanho = null;
            // Console.WriteLine(texto);
            // Console.WriteLine(salario * 1000);
            // Console.WriteLine(buli);
            // Console.WriteLine(sexo);
            // Console.WriteLine(nome);
            // Console.WriteLine(idade);
            // Console.WriteLine(nome1);
            //CONVERSÃO IMPLÍCITA
            float valor = 25.8f;
            int outro = 25;
            valor = outro;
            // string nome = "Anthony"; - NÃO É POSSÍVEL CONVERSÃO IMPLÍCITA DE CHAR PARA STRING.
            // char letra = 'A';
            // nome = letra;
            // outro = valor; - NÃO É PERMITIDO USANDO CONVERSÃO IMPLÍCITA.
            // Console.WriteLine(outro);
            //FIM DA CONVERSÃO IMPLÍCITA
            //CONVERSÃO EXPLÍCITA
            // int inteiro = 100;
            // uint inteiroSemSinal = (uint)inteiro;
            // Console.WriteLine(inteiroSemSinal);
            //FIM DA CONVERSÃO EXPLÍCITA.
            //CONVERSÃO USANDO O PARSE
            // int inteiro = int.Parse("100");
            // Console.WriteLine(inteiro);
            //FIM DA CONVERSÃO USANDO PARSE.
            //CONVERSÃO USANDO CONVERT
            // int inteiro = Convert.ToInt32("100");
            // Console.WriteLine(inteiro);
            int inteiro = 100;
            float real = 25.99f;
            inteiro = (int)real;
            Console.WriteLine(inteiro);
            //FIM DA CONVERSÃO USANDO CONVERT
            // Console.WriteLine(idade);
            // Console.WriteLine(tamanho);

        }
    }
}
