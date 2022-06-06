using System; 

class URI {

    static void Main(string[] args) { 
        double r = Convert.ToDouble(Console.ReadLine());
        double n = 3.14159;

        double area = Math.Pow(r, 2)*n;
        Console.WriteLine("A="+area.ToString("F4"));
    }
}