using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Loop_Condition.classes
{
    public class User
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public string job {  get; set; }
        public string department { get; set; }

        public int age {  get; set; }
        public double wage { get; set; }    
        public String Categorize()
        {
            if(age >= 0 && age<18) {
                return("Küçüksünüz");

            }
            else if(age >= 18 && age < 35)
            {
                return ("Gençsiniz");

            }
            else if (age >=35 &&  age < 55)
            {
                return ("Yetişkinsiniz");

            }
            else if (age>= 55 &&  age < 75)
            {
                return ("Yaşlısınız");

            }
            else if (age >= 75 &&  age < 99)
            {
                return ("Çok yaşlısınız");
            }
            else
            {
                return ("Ya hiç doğmadınız ya da çoktan öldünüz...");
            }
        }
    }
}
