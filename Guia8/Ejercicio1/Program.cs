namespace Ejercicio1
{
    internal class Program
    {
        static int acumulador;
        static int contador;
        static int maximo;
        static int minimo;

        static void RegistrarValor(int valor)
        {
            acumulador = valor;
            contador++;

            if (acumulador > maximo)
            {
                maximo = valor;
            }
            if (acumulador < minimo)
            {
                minimo = valor;
            }
        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if(contador > 0)
            {
                promedio = 1.0 * acumulador / contador;
            }
            return promedio;
        }

        static int MostrarPantallaSolicitarMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguientes opciones:");
            Console.WriteLine("1_ Procesar un solo numero");
            Console.WriteLine("2_ Procesar varios numeros");
            Console.WriteLine("3_ Mostrar el numero maximo y minimo");
            Console.WriteLine("4_ Mostrar promedio");
            Console.WriteLine("5_ Mostrar cantidad de numeros ingresados");
            Console.WriteLine("6_ Reiniciar las variables");
            Console.WriteLine("Salir");
            int opciones = Convert.ToInt32(Console.ReadLine());
            return opciones;
        }

        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciar las variables");
            acumulador = 0;
            contador = 0;
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese cuantos numeros va a querer ingresar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                MostrarPantallaSolicitarNumeros();
            }
        }

        static void MostrarPantallaMaxyMin()
        {
            Console.Clear();
            Console.WriteLine("Maximo y minimo");
            Console.WriteLine("Maximo: "+ maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Presione alguna tecla para volver al menu");
            Console.ReadKey();
        }

        static void MostrarPantallaCalcularPromedio()
        {
            Console.Clear();
            Console.WriteLine("Calcular promedio: ");
            if (contador > 0)
            {
                Console.WriteLine("Promedio: " + CalcularPromedio);
            }
            else
            {
                Console.WriteLine("Promedio: No se ingresaron valores");
            }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de valores procesados");
            if (contador > 0)
            {
                Console.WriteLine("Cantidad: " + contador);
            }
            else
            {
                Console.WriteLine("Cantidad: No se ingresaron valores");
            }

            Console.WriteLine("Presione alguna tecla para volver al menu");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MostrarPantallaIniciarVariables();
            int opciones = MostrarPantallaSolicitarMenu();

            while (opciones != -1)
            {
                switch (opciones)
                {
                    case 1: MostrarPantallaSolicitarNumeros(); break;
                    case 2: MostrarPantallaSolicitarVariosNumeros(); break;
                    case 3: MostrarPantallaMaxyMin(); break;
                    case 4: MostrarPantallaCalcularPromedio(); break;
                    case 5: MostrarPantallaCantidad(); break;
                    case 6: MostrarPantallaIniciarVariables(); break;
                    default: opciones = -1; break;
                }
                if (opciones != -1)
                {
                    opciones = MostrarPantallaSolicitarMenu();
                }
            }
        }
    }
}
