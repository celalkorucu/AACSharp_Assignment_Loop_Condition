using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Loop_Condition.classes
{
    internal class Worker : User
    {
       public static  void SumWage(List<Worker> workers)
        {
            double sum = 0;
            foreach (Worker worker in workers)
            {

                Console.WriteLine("Çalışan Ad : "+worker.name);
                Console.WriteLine("Çalışan Soyad : " + worker.surname);
                Console.WriteLine("Çalışan Meslek : " + worker.job);
                Console.WriteLine("Çalışan Maaş : " + worker.wage);
                Console.WriteLine("Çalışan Departman: " + worker.department);
   
                double wage = worker.wage;
                sum += wage;
            }
            Console.WriteLine("Çalışanların Toplam Maaşı : " + sum);
        }
    }
}
