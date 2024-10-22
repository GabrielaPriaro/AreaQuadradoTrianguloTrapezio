//Problema "medidas"
//Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar (imprimir os dados
//com quatro casas decimais):
//a) a área do quadrado que tem lado A
//b) a área do triângulo retângulo que base A e altura B
//c) a área do trapézio que tem bases A e B, e altura C 

using System.Globalization;

namespace AreaQuadradoTrianguloTrapezio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double medidaA, medidaB, medidaC, areaQuadrado, areaTriangulo, areaTrapezio;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida A: ");
            medidaA = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            medidaB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            medidaC = double.Parse(Console.ReadLine(), CI);

            areaQuadrado = Math.Pow(medidaA, 2);
            areaTriangulo = (medidaA * medidaB) / 2;
            areaTrapezio = ((medidaA + medidaB) * medidaC) / 2;

            Console.WriteLine($"AREA DO QUADRADO = {areaQuadrado.ToString("F4", CI)}");
            Console.WriteLine($"AREA DO TRIANGULO = {areaTriangulo.ToString("F4", CI)}");
            Console.WriteLine($"AREA DO QUADRADO = {areaTrapezio.ToString("F4", CI)}");
        }
    }
}
