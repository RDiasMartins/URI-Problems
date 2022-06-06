using System; 

class URI {

    static void Main(string[] args) { 
        string[] texto = Console.ReadLine().Split(" ");
        int c1 = Convert.ToInt32(texto[0]);
        int n1 = Convert.ToInt32(texto[1]);
        int v1 = Convert.ToDouble(texto[3]);
        
        string[] texto2 = Console.ReadLine().Split(" ");
        int c2 = Convert.ToInt32(texto2[0]);
        int n2 = Convert.ToInt32(texto2[1]);
        int v2 = Convert.ToDouble(texto2[3]);

        double total = (n2*v2)+(n2*v2);
        Console.WriteLine("VALOR A PAGAR: R$ "+total.ToString("F2"));
    }

}