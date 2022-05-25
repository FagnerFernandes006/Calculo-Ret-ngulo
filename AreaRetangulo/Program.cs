using System.Globalization;
namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com as medidas do retângulo: ");
            Console.Write("Base: ");
            retangulo.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();
            Console.WriteLine();
            Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
