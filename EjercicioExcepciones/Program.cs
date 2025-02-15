using EjercicioExcepciones;

int opcion;
Operaciones operaciones = new Operaciones();

do
{
    Console.Clear();
    Console.WriteLine("Menú de operaciones básicas");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir del programa");
    Console.WriteLine("Por favor, elija una opción:");

    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        opcion = -1;
    }

    if (opcion == 5)
    {
        Console.WriteLine("Saliendo...");
        break;
    }

    double num1, num2;
    try
    {
        Console.WriteLine("Ingrese el primer número:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debes ingresar un número válido.");
        continue;
    }

    try
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Suma: {operaciones.Suma(num1, num2)}");
                break;

            case 2:
                Console.WriteLine($"Resta: {operaciones.Resta(num1, num2)}");
                break;

            case 3:
                Console.WriteLine($"Multiplicación: {operaciones.Multiplicacion(num1, num2)}");
                break;

            case 4:
                Console.WriteLine($"División: {operaciones.Dividir(num1, num2)}");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
} while (opcion != 5);
