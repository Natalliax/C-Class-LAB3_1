//Матюшенко Наталья 20331гр.
using System.Xml.Linq;

namespace LAB3_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Procent procent1 = new Procent("Виатранс", 1000, 35, 35000, 45, 45000);
            Console.WriteLine(procent1);
            Console.WriteLine(procent1.ProcentVyr());

        }



    }

       
}