using System;

namespace CalculadoraApp
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            if(a == 0 || b == 0)
            {
                Console.WriteLine("Uno de los números es 0.");
                return 0;
            }
            return a + b;
        }

        public int Restar(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("El primer número debe ser mayor que el segundo.");
                return 0;
            }
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            if(a == 0 || b == 0)
            {
                Console.WriteLine("Multiplicación por cero.");
                return 0;
            }
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                return 0;
            }
            return (double)a / b;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
        }

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int opcion = 0;
            int num1, num2;
            
            while (opcion != 5)
            {
                calc.MostrarMenu();
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer número:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + calc.Sumar(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + calc.Restar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + calc.Multiplicar(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Resultado: " + calc.Dividir(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
