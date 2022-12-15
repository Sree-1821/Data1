using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    class date
    {
        public int year { get; set; }

        public int month { get; set; }
        public int day { get; set; }


        //default constructor
        public date()
        {
            year = 2002;
            month = 1;
            day = 1;

        }
        public date(int y, int m, int d)
        {
            this.year = y;
            this.month = m;
            this.day = d;
        }
        public override string ToString()
        {
            return "" + day + "/" + month + "/" + year;
        }

        //public void DiplayDate()       
        //{      
        //    Console.WriteLine(Day  +" /"  +Month + " / " + Year);     
        //}    }

        class DateMainCLass
        {
            public static void Main()
            {
                date obj = new date(1, 1, 2022);          //  obj.ToString();          
                Console.WriteLine(obj);
                Console.ReadKey();
            }
        }


    }
}
