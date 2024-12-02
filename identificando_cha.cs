using System; 

class URI {

    static void Main(string[] args) { 

        int tipoCha = int.Parse(Console.ReadLine());

        string[] respostasInput = Console.ReadLine().Split(' ');
        int[] respostas = Array.ConvertAll(respostasInput, int.Parse);

        int corretas = 0;
        foreach (int resposta in respostas)
        {
            if (resposta == tipoCha)
            {
                corretas++;
            }
        }

        Console.WriteLine(corretas);

    }

}