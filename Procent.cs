using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1
{

    public class Procent
    {
        public string? name; //название вычисления
        public double fraht = 1000;
        public double SumTonn = 35;
        public double Vyr = 35000;
        public double MaxTonn = 45;
        public double MaxVyr = 45000;
        public double procent = 0;


        public Procent(string Name, double Fraht, double sumTonn, double vyr, int maxTonn, double maxVyr)
        {
            this.name = Name;
            this.MaxTonn = maxTonn;
            this.fraht = Fraht;
            this.SumTonn = sumTonn;
            this.MaxVyr = maxVyr;
            this.Vyr = vyr;

        }


        public double ProcentVyr()
            // метод для определения процентной выручки от максимально возможной
            //(суммарную грузоподъемность умножить на стоимость перевозки 1
            //тонны)
        {
         
            for (int i = 0; i < MaxTonn; i++)
            {
                procent = (Vyr * 100)/MaxVyr;
               
            }
            return procent;
        }
        public override string ToString()

        {
            return $"Название  {name}\n" +
                   $"Сумма тонн {SumTonn}\n" +
                   $"Выручка {Vyr}\n" +
                   $"Максимально тонн {MaxTonn}\n" +
                   $"Максимальная выручка {MaxVyr}\n";
        }
    }

}

