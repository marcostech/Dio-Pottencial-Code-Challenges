//Necessário incluir para utilizar Console
using System;
using System.IO;
using System.Linq;
class DIO {
    static void Main(string[] args)
    {
        int qt = 0;
        //Tentativa de Parse
        int.TryParse(Console.ReadLine(), out qt);
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i<qt; i++)
        {   
            //lê input do usuario A + B
            string userInput = Console.ReadLine();
            //Separa os inputs por " "            
            string[] v = userInput.Split(null);
            string a = v[0];
            string b = v[1];
            //lógica do desafio
            if (!a.EndsWith(b))
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}