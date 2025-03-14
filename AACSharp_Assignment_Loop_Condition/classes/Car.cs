using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Loop_Condition.classes
{
    public class Car
    {
        public int age { get; set; }

        public double fuelConsumption { get; set; }
        public string Categorize()
        {
            if (age >= 0 && age < 10)
            {

                return "Arabanız yeni";
            }
            else if (age >= 10 && age < 20)
            {
                return "Servise götürmeniz gerekebilir";

            }
            else if (age >= 20 && age < 30)
            {
                return "Arabanız hurdaya çıkabilir";

            }
            else
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";

            }
        }
    
        public static double Sum(List<Car> cars)
        {
            double sum = 0; 
            foreach (Car car in cars)
            {
                sum += car.fuelConsumption;
            }
            return sum;
        }
    
    }
}
