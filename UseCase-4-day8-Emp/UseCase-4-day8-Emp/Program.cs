﻿using System;

namespace UseCase_4
{
    public class Uc_4_emp
    {
        //Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;

        //Variables
        public int empHrs = 0;
        public int empWage = 0;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Uc_4_emp uc4 = new Uc_4_emp();
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    uc4.empHrs = 8;
                    break;
                case 2:
                    uc4.empHrs = 4;
                    break;
                default:
                    uc4.empHrs = 0;
                    break;
            }
            uc4.empWage = uc4.empHrs * uc4.emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage =" + uc4.empWage);
        }
    }
}

