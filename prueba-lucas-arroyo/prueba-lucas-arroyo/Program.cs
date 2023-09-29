internal class Program
{
    public static void Main(string[] args)
    {
        Program programa = new Program();

        // Si realizamos la llamada sin parámetros, nos pedirá dos números y la operación a realizar
        programa.Ejercicio1();

        // Si realizamos la llamada con parámetros, realizará la operación indicada automáticamente (descomentar línea inferior para comprobar)
        //programa.Ejercicio1(3, 3, "+");

        // Si realizamos la llamada sin pasarle el número, nos lo pedirá al ejecutar el método
        programa.Ejercicio2();

        // Si realizamos la llamada con el número como parámetro, se ejecutará el método directamente (descomentar línea inferior para comprobar)
        //programa.Ejercicio2(10);
    }

    private void Ejercicio1(double num1 = 0, double num2 = 0, string simbolo = "")
    {
        var resultado = 0.0;

        Console.WriteLine("EJERCICIO 1:");

        if (num1 == 0)
        {
            Console.WriteLine("\nPrimer número:");
            num1 = PedirNumero();
        }

        if (num2 == 0) {
            Console.WriteLine("\nSegundo número:");
            num2 = PedirNumero();
        }

        if (string.IsNullOrEmpty(simbolo))
        {
            Console.WriteLine("\nOperación (+, -, *, /):");
            simbolo = PedirSimbolo();
        }

        switch (simbolo)
        {
            case "+":
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es {resultado}");
                break;
            case "-":
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es {resultado}");
                break;
            case "*":
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es {resultado}");
                break;
            case "/":
                resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es {resultado}");
                break;
        }

        if (!EsPrimo(resultado))
            Console.WriteLine($"El número {resultado} no es primo");

    }

    private void Ejercicio2(int num = 0)
    {
        var num1 = 0;
        var num2 = 1;
        var sumaPar = 0;
        var sumaImpar = 0;

        var cadena = "";

        Console.WriteLine("EJERCICIO 2:");

        if (num == 0)
        {
            Console.WriteLine("Introduce un número:");
            num = (int)PedirNumero();
        }

        for (int i = 0; i < num; i++)
        {
            if (i != 0)
            {
                var aux = num1;
                num1 = num2;
                num2 = aux + num1;
            }

            if (i == 0)
            {
                cadena = "0";
            }
            else
            {
                if (num1 % 2 == 0)
                {
                    sumaPar += num1;
                }
                else
                {
                    sumaImpar += num1;
                }

                cadena += $", {num1}";
            }
        }

        Console.WriteLine($"{cadena}. Suma pares: {sumaPar}. Suma impares: {sumaImpar}");
    }

    private bool EsPrimo(double resul)
    {
        var num = (int)(resul);

        if (num <= 1)
            return false;
        if (num <= 3)
            return true;

        // Verificamos si es divisible por 2 o 3
        if (num % 2 == 0 || num % 3 == 0)
            return false;

        // Comprobamos divisibilidad con números desde 5 hasta la raíz cuadrada del número
        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }

    private double PedirNumero()
    {
        var num = 0.0;

        var entrada = Console.ReadLine();

        // Si la entrada no es un número, mostramos un mensaje y volvemos a solicitarla
        while (!double.TryParse(entrada, out num))
        {
            Console.WriteLine("\nLa entrada debe ser numérica!");
            entrada = Console.ReadLine();
        }

        return num;
    }

    private string PedirSimbolo()
    {
        var simbolo = Console.ReadLine();

        // Si la entrada no es +, -, * o /, mostramos un mensaje y volvemos a solicitarla
        while (simbolo != "+" && simbolo != "-" && simbolo != "*" && simbolo != "/")
        {
            Console.WriteLine("\nLa entrada debe ser uno de los carácteres indicados! ((+, -, *, /):");
            simbolo = Console.ReadLine();
        }

        return simbolo;
    }
}