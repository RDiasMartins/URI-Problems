using System; 

class URI {

    static void Main(string[] args) { 
        double r = Convert.ToDouble(Console.ReadLine());
       
        double volume = (4/3.0)*3.14159*Math.Pow(r,3);
        Console.WriteLine("VOLUME = "+volume.ToString("F3"));
    }

}