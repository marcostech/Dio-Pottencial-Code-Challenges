using System;
 
class Solution {
    public static void Main(string[] args) {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int count = 0;
        //caso número seja negativo transforme em positivo, para facilitar a lógica
        if (n < 0) {
            n *= -1;
        }
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i == 0) {
                count++;
            }
            if (count == 3) {
                break;
            }
        }
         Console.WriteLine(count == 3);
    }
}