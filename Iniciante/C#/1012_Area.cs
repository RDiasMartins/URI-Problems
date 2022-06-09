using System; 

class URI {

    static void Main(string[] args) { 
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double triangulo = (a*c)/2;
        double circulo = Math.Pow(c, 2)*3.14159;
        double trapezio = (a*b*c)/2;
        double quadrado = Math.Pow(b,2);
        double retangulo = a*b;

        Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3")+"\nCIRCULO: "+circulo.ToString("F3")
            +"\nTRAPEZIO: "+trapezio.ToString("F3")
            +"\nQUADRADO: "+quadrado.ToString("F3")
            +"\nRETANGULO: "+retangulo.ToString("F3"));
    }

}