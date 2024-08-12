using System;
using System.Threading.Tasks.Dataflow;


namespace TinhTienLaiNganHang
{
    class Program
    {
        static void Main(string[]args)
        {
            double monney;
            float BankInterestRate;
            int month;
            double profit=0;

            Console.WriteLine("Tinh tien lai cua ngan hang");
            Console.WriteLine("***************************");
            Console.Write("Nhap vao so tien muon gui (VND): ");
            while(true)
            {
                if (double.TryParse(Console.ReadLine(),out monney)&& monney>0)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai so tien muon gui: ");
                }
            }
            Console.Write("Nhap vao % lai suat cua ngan hang: ");
            while(true)
            {
                if (float.TryParse(Console.ReadLine(),out BankInterestRate)&& BankInterestRate>0)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai % lai suat cua ngan hang: ");
                }
            }
            Console.Write("Nhap vao ky han muon gui (thang): ");
            while(true)
            {
                if (int.TryParse(Console.ReadLine(),out month)&& month>0)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai ky han muon gui (thang): ");
                }
            }
            for (int i=0; i<month; i++)
            {
                profit += Math.Round(monney*((BankInterestRate/100)/12),2);
            }
            
            Console.Write("Tien lai khi gui [{0}] trong vong [{1}] thang voi lai suat [{2}%] la: {3} VND",monney, month, BankInterestRate,profit);
          
        }
    }
}