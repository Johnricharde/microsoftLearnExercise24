using System.Text;

namespace microsoftLearnExercise24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            Console.WriteLine($"$ {usd} USD = ₫ {vnd} VND");

            Console.WriteLine($"₫ {vnd} VND = $ {VndToUsd(vnd)} USD");

            int UsdToVnd(double usd)
            {
                int rate = 23500;
                return (int)(rate * usd);
            }
            double VndToUsd(int vnd)
            {
                double rate = 23500;
                return vnd / rate;
            }
        }
    }
}
