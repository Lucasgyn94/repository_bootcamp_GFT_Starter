
// Projeto com erro de exceção

public class ExceptionTest
{
    public static void Main(string[] args)
    {
        int a = 100, b = 0;
        double resultado = 0;

        resultado = Dividir(a, b);
        Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
    }

    public static double Dividir(int x, int y)
    {
        return (x / y);
    }
}