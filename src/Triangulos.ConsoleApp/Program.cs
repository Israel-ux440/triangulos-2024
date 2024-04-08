namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os comprimentos dos três lados do triângulo:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(x, y, z);
            triangulo.VerificarTipoTriangulo();

            Console.ReadLine(); // Para manter a janela do console aberta
        }
    }
}

