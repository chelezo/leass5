using System;
using System.IO;
namespace SaveToTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            confSaveToTxt simple = new confSaveToTxt();
            simple.TextHello();
            simple.NumCompany = Convert.ToInt32 (Console.ReadLine());

            for (int a = 0; a < simple.NumCompany; a++)
                {
                System.Console.WriteLine("Введите фирму под номером " + a);
                simple.NameCompany = Console.ReadLine( );                
                File.AppendAllText("namecom.txt", simple.NameCompany);
            }
            string loadCompany = File.ReadAllText("namecom.txt");
            Console.WriteLine(loadCompany);
            simple.FileDelete();
            int FDelete = Convert.ToInt32(Console.ReadLine());
            if (FDelete == 1)
            {
                File.Delete("namecom.txt");
                simple.YesDel();

            }
            else if (FDelete == 2)
            {
                simple.NoFileDelete();

            }
            else {
                simple.ErrorNum();
                
            }
            
        }
    }
}
