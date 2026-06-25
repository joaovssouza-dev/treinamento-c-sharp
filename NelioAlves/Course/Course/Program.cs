namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 4.5f;
            double b = a; // converte implicitamente
            double c = 4.5;
            float d = (float)c; // não consegue converter implicitamente, somente com o casting
            int e = (int)c; // mesmo problema de cima

            var f = 5;
            var g = 2;

            double resultado = (double) f / g; // precisa de casting, senão retorna valor com mesmo tipo das variáveis
            Console.WriteLine(resultado);
        }
    }
}