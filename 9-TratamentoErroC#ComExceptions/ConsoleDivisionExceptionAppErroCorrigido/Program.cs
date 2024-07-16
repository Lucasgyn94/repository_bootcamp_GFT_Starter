using System;
using ConsoleDivisionExceptionAppErroCorrigido;

public class ExceptionTest
{
    public static void Main(string[] args)
    {
        int a = 100, b = 0;
        double resultado = 0;

        try{
            resultado = Dividir(a, b);
        }
        catch(DivideByZeroException ex) //when (a < 0)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message); // imprime: Attempted to divide by zero. Uma exceção mais especifica;
            //throw;
        }
        finally
        {
            Console.WriteLine("Finalmente a divisão foi finalizada");
        }
    }
    public static double Dividir(int x, int y)
    {
        if(y == 0)
        {
            throw new MyClassException("Minha mensagem customizada de erro");
            //throw ncd ew DivideByZeroException();
            //throw new ArithmeticException();
        }
        return (x / y);
    }
}