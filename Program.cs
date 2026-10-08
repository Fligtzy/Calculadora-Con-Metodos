namespace C__calculadora
{
 
        internal class Program
        {
            static double Sumar(double a, double b)
            {
                return a + b;
            }

            static double Restar(double a, double b)
            {
                return a - b;
            }

            static double Multiplicar(double a, double b)
            {
                return a * b;
            }

            static string Dividir(double a, double b)
            {
                if (b == 0)
                {
                    return "Error, no se puede dividir entre cero";
                }
                return (a / b).ToString();
            }

        
            static double LeerNumero(string mensaje)
            {
                Console.Write(mensaje);
                return double.Parse(Console.ReadLine());
            }

            static void Main(string[] args)
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine();

                //declarar
                double n1, n2;

                n1 = LeerNumero("Ingrese el Primer Numero: ");
                n2 = LeerNumero("Ingrese el Segundo Numero: ");

                Console.WriteLine();
                Console.WriteLine("Suma: " + Sumar(n1, n2));
                Console.WriteLine("Resta: " + Restar(n1, n2));
                Console.WriteLine("Multiplicacion: " + Multiplicar(n1, n2));
                Console.WriteLine("Division: " + Dividir(n1, n2));
              
            }
        }
    }
