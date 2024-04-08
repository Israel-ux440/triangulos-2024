namespace Triangulos.ConsoleApp
{
    class Triangulo
    {
        public double lado1;
        public double lado2;
        public double lado3;

        public Triangulo(double x, double y, double z)
        {
            lado1 = x;
            lado2 = y;
            lado3 = z;
        }

        public void VerificarTipoTriangulo()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("É um triângulo equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("É um triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo.");
            }
        }
    }
}

