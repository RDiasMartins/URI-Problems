using System; 

class URI {

    static void Main(string[] args) { 
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        double r = (a*3.5 + b*7.5)/11;
        Console.WriteLine("MEDIA = "+r.ToString("F5"));
    }

}