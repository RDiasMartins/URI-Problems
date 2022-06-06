using System; 

class URI {

    static void Main(string[] args) { 
        string nome = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double vendas = Convert.ToDouble(Console.ReadLine());

        double r = vendas*0.15+salario;
        Console.WriteLine("TOTAL = R$ "+r.ToString("F2"));
    }

}