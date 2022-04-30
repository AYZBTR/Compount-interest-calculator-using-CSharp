using System;

namespace Compount_interest_calculator_using_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double AnnualIntrest;
            double ratio;
            double AnnualDeposit;
            double OriginalDeposit;
            double OriginalDepositCompound;
            double GeometricSum;
            double total;
            int numberofYears;

            bool more;
            do
            {


                Console.Write("Annual Intrest(%): ");
                String received = Console.ReadLine();

                while (!Double.TryParse(received, out AnnualIntrest) || AnnualIntrest < 0)
                {
                    Console.WriteLine("Not valid, try again: ");
                    received = Console.ReadLine();

                }
                ratio = 1 + AnnualIntrest / 100;

                Console.Write("Number of years: ");
                received = Console.ReadLine();
                while (!Int32.TryParse(received, out numberofYears) || numberofYears < 0)
                {
                    Console.WriteLine("Not Valid, Try Again!");
                    received = Console.ReadLine();

                }
                Console.Write("Annual Deposit:");
                received = Console.ReadLine();
                while (!Double.TryParse(received, out AnnualDeposit) || AnnualDeposit < 0)
                {
                    Console.WriteLine("Not Valid, Try Again!");
                    received = Console.ReadLine();
                }

                Console.Write("Original Deposit:");
                received = Console.ReadLine();
                while (!Double.TryParse(received, out OriginalDeposit) || OriginalDeposit < 0)
                {
                    Console.WriteLine("Not Valid, Try Again!");
                    received = Console.ReadLine();
                }
                //Original deposit
                //call your method:

                OriginalDepositCompound = calcOriginalDC(OriginalDeposit, ratio, numberofYears);
                //Annual deposits:
                GeometricSum = CalcGeometricSum(AnnualDeposit, ratio, numberofYears);
                GeometricSum = AnnualDeposit * (1 - Math.Pow(ratio, numberofYears)) / (1 - ratio);
                total = OriginalDepositCompound + GeometricSum;

                Console.WriteLine("Child will get {0:F2} euros. ", total);

                Console.Write("More exprements (Y/N):");
                string decision = Console.ReadLine().ToUpper();
                if (decision.StartsWith("Y"))
                    more = true;
                else
                    more = false;



            } while (more);
        }

        //Define your methods here:

        public static double calcOriginalDC(double originalD, double commonR, int years)
        {
            return originalD * Math.Pow(commonR, years);
        }

        public static double CalcGeometricSum(double annualD, double commonR, int years)
        {
            return annualD * (1 - Math.Pow(commonR, years)) / (1 - commonR);
        }
    }
}
    
