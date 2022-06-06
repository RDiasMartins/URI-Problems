using System; 

class URI {

    static void Main(string[] args) { 
        int numero = Convert.ToInt32(Console.ReadLine());
        int horas = Convert.ToInt32(Console.ReadLine());
        double valorHora = Convert.ToDouble(Console.ReadLine());

        double r = horas*valorHora;
        Console.WriteLine("NUMBER = "+numero+"\nSALARY = U$ "+r.ToString("F2"));
    }

}