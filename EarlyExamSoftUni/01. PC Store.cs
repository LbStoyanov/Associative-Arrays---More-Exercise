using System;

namespace EarlyExamSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Dollarscurs = 1.57;

            double proccesorPriceInDollars = double.Parse(Console.ReadLine());
            double videoCardPriceInDollars = double.Parse(Console.ReadLine());
            double ramPriceInDollars = double.Parse(Console.ReadLine());

            double ramQuantity = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double proccesorPriceInlv = proccesorPriceInDollars * Dollarscurs;
            double videoCardPriceInLeva = videoCardPriceInDollars * Dollarscurs;
            double ramPriceInLeva = (ramPriceInDollars * Dollarscurs) * ramQuantity;
            double totalPriceForProccesorAndVideoCardPrice = proccesorPriceInlv + videoCardPriceInLeva;
            double finalPriceForProccesorAndVideoCardAfterDiscount = totalPriceForProccesorAndVideoCardPrice - (totalPriceForProccesorAndVideoCardPrice * discount);
            double totalAmount = finalPriceForProccesorAndVideoCardAfterDiscount + ramPriceInLeva;
            Console.WriteLine($"Money needed - {totalAmount:f2} leva.");

        }
    }
}
