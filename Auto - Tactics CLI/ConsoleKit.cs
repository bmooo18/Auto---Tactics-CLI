// Utilidades de consola que el curso entrega ya terminadas.
// No hace falta entender este archivo para usarlas: basta con conocer su interfaz pública.
// La clase es estática: sus métodos se llaman con el nombre de la clase, sin new.
public static class ConsoleKit
{
    // Constructor estático: C# lo ejecuta una sola vez, justo antes del primer uso de la clase.
    static ConsoleKit()
    {
        try
        {
            // UTF-8 para que los acentos y símbolos como ★ y → se vean bien.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
        catch (System.IO.IOException)
        {
            // Algunas consolas no permiten cambiar la codificación; el programa sigue funcionando.
        }
    }
 
    // Lee una letra y la vuelve a pedir hasta que sea una de validKeys.
    // Acepta mayúsculas y minúsculas y devuelve la letra en mayúscula.
    public static char ReadOption(string validKeys)
    {
        string allowed = validKeys.ToUpper();
        while (true)
        {
            string input = ReadInputLine().Trim();
            if (input.Length == 1)
            {
                char option = char.ToUpper(input[0]);
                if (allowed.Contains(option))
                {
                    return option;
                }
            }
            Console.Write(" Opción no válida. Intenta de nuevo: ");
        }
    }
 
    // Lee un número entero y lo vuelve a pedir hasta que esté entre min y max, inclusive.
    public static int ReadNumber(int min, int max)
    {
        while (true)
        {
            string input = ReadInputLine().Trim();
            if (int.TryParse(input, out int number) && number >= min && number <= max)
            {
                return number;
            }
            Console.Write($" Escribe un número entre {min} y {max}: ");
        }
    }
 
    // Detiene el programa durante los milisegundos indicados.
    public static void Pause(int milliseconds)
    {
        System.Threading.Thread.Sleep(milliseconds);
    }
 
    // Limpia la consola.
    public static void Clear()
    {
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
            // Algunas consolas (como la ventana Run de Rider sin terminal) no se pueden limpiar.
        }
    }
 
    // Completa el texto con espacios a la derecha hasta width caracteres, para alinear columnas.
    public static string PadRight(string text, int width)
    {
        return text.PadRight(width);
    }
 
    // Lee una línea de la consola.
    // Si la entrada se cerró (Ctrl+Z o Ctrl+D), detiene el programa con un aviso.
    private static string ReadInputLine()
    {
        string? line = Console.ReadLine();
        if (line == null)
        {
            throw new InvalidOperationException("La entrada de la consola se cerró.");
        }
        return line;
    }
}