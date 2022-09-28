using System;
class Dio
{
    private static void Main(string[] args)
    {
        int numero = 0;
        bool conversao = false;
        do
        {
            //Console.WriteLine("Escreva um número inteiro, maior que zero e menor que 10^5");
            conversao = int.TryParse(Console.ReadLine(), out numero);
            /*
            if (numero <= 0 || !conversao)
            {
                Console.WriteLine("Erro, número DEVE ser maior que zero e menor que 10^5");
            }
            */
        } while (numero <= 0 || !conversao);

        int produto = 1, soma = 0;
        while (numero > 0)
        {
            int digito = numero % 10;            
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            produto *= digito;
            soma += digito;
            numero /= 10;
        }

        Console.WriteLine(produto - soma);
    }
}