using System; 

class URI {

    static void Main(string[] args) { 
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        int r = a*b-c*d;
        Console.WriteLine("DIFERENCA = "+r);
    }

}