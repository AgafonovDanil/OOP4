using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4
{
    class HealthLife
    {
        private int Life;

        public int TemperaturePerson
        {
            get
            {
                return Life;
            }
            set
            {
                if (value < 34 || value > 41)
                    Console.WriteLine("Вы умераете");

                else
                    Console.WriteLine("Ваша температура составляет  " + value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру");
            int writeTemperature = Convert.ToInt32(Console.ReadLine());
            HealthLife newTem = new HealthLife();

            newTem.TemperaturePerson = writeTemperature;
            Console.ReadKey();
        }
    }
}




