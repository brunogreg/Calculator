using System;
using System.Globalization;

namespace Course {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o valor de terrenos");
            Console.WriteLine("Informe a medida da Largura do terreno:");
            double width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a medida do comprimento do terreno:");
            double length = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double area = (width * length);
            Console.WriteLine("Informe o valor do metro quadrado:");
            double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double ValorTotal = area * price;    
            Console.WriteLine("A area desse terreno informado é: " + area.ToString("F2", CultureInfo.InvariantCulture) + " Metros quadrados");
            Console.WriteLine("O valor total desse terreno informado é: " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture) + " Reais");
            Console.WriteLine("Aperte qualquer tecla para sair");
        }
    }
}
