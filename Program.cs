using System;

namespace EmpWagePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            UC1Emp_Present_Absent.AttendaceCheck();
            UC2_EmpDaily_Wage.EmpDailyWage();
            UC3_PartTime_Emp_Wage.PartTime();
            UC4_Case_Satement.case_statement();
            UC5_Wage_Month.Wage_of_Month();
            UC6_100hrs_Month.No_Of_WorkingDays_Wage();
            Console.ReadLine();
        }
    }
}
