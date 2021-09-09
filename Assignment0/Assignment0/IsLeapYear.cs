using System;

namespace Assignment0{

    public class Methods{

        public bool IsLeapYear(int year){


            if(year > 1582){
                if(year %4 == 0 && year %400 == 0){
                    Console.WriteLine("Yay");
                    return true;
                }
                if(year %4 == 0 && year %100 == 0){
                    Console.WriteLine("Nay");
                    return false;
                }
                if(year %4 == 0 && year %100 != 0 && year %400 != 0){
                    Console.WriteLine("Yay");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nay");
                    return false;
                    
                }
            }
            else
                Console.WriteLine("Year must be from 1582 and onwards");
                return false;
        }
    }
}