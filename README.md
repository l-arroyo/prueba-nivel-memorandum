# Prueba de nivel de Lucas Arroyo para Memorándum Multimedia

## Instrucciones de ejecución

Los dos primeros ejercicios se encuentran en el método Program.cs de la carpeta `prueba-lucas-arroyo`. Para ejecutar la aplicación nos tenemos que asegurar de tener como mínimo la versión net6.0 del sdk instalada en nuestro equipo. Para ello ejecutamos el comando `dotnet --info` en la terminal.

Una vez asegurados, nos situamos en el directorio del programa con `cd .\prueba-lucas-arroyo\prueba-lucas-arroyo` y ejecutamos el comando `dotnet run`.

## Aclaraciones

En ambos ejercicios, puedes llamar a los métodos con o sin parámetros, de forma que si no se recibe ningún parámetro en la llamada, se pedirán al usuario los datos necesarios por consola y se validará la entrada de los mismos.

Por defecto los métodos se llaman sin parámetros, pero se pueden descomentar las líneas en el programa para que se llamen con parámetros:

```csharp
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
```