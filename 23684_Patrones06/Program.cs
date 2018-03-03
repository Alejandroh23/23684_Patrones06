using System;

namespace _Patrones06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            beverage PayeLate = new payeLate("Grande");
            PayeLate = new Leche(payeLate);
            PayeLate = new Espresso(payeLate);

            Console.WriteLine(payeLatte.getDescription());
            Console.WriteLine(payeLatte.getCost());

            beverage payachai = new PayaChai("Mediano");
            payachai = new Leche(PayaChai);
            payachai = new Agua(PayaChai);

            Console.WriteLine(PayaChai.getDescription());
            Console.WriteLine(PayaChai.getCost());

            beverage PayuExpress = new payuExpress("Chico");
            PayuExpress = new Espresso(payuExpress);
            PayuExpress = new Agua(payuExpress);

            Console.WriteLine(PayuExpress.getDescription());
            Console.WriteLine(PayuExpress.getCost());

            beverage payuMoca = new PayuMoca("");
            payuMoca = new Espresso(PayuMoca);
            payuMoca = new Agua(PayuMoca);
            payuMoca = new Leche(PayuMoca);

            Console.WriteLine(PayuMoca.getDescription());
            Console.WriteLine(PayuMoca.getCost());
        }
    }
