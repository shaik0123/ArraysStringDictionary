using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArrayStringDictionary
{
    interface IEmpData
    {
        public void EmpWageCalculation(string CompanyName, int DailyWage, int MaxHrsInMonth, int MaxWorkingDaysInMonth);
    }
    public class EmpClass : IEmpData
    {
        ArrayList List = new ArrayList();
        public void EmpWageCalculation(string CompanyName, int DailyWage, int MaxHrsInMonth, int MaxWorkingDaysInMonth)
        {
            int totalEmpHrs = 0;
            int totalWorkDays = 0;
            int totalEmpWage = 0;
            int partTime = 1;
            int fullTime = 2;

            while (totalEmpHrs <= MaxHrsInMonth && totalWorkDays < MaxWorkingDaysInMonth) 
            {
                int empHrs;
                totalWorkDays++;
                Random random = new Random();
                int check = random.Next(0, 3);

                Console.WriteLine("random value : " + check);

                if (check == partTime)
                {
                    empHrs = 8;
                }
                else if (check == fullTime)
                {
                    empHrs = 12;
                }
                else
                {
                    empHrs = 0;
                }
                totalEmpHrs += empHrs;
                DailyWage = empHrs * DailyWage;
                Console.WriteLine("wage : " + DailyWage);
                totalEmpWage += totalEmpHrs* DailyWage;
            }
            Storage Storage = new Storage(CompanyName, DailyWage, MaxHrsInMonth, MaxWorkingDaysInMonth, totalEmpWage);
            List.Add(Storage);
            Console.WriteLine(List);
        }
        
    }
    public class Storage
    {
        public string companyName;
        public int dailyWage;
        public int maxHrsInMonth;
        public int maxWorkingDaysInMonth;
        public int totalEmpWage;

        public Storage(
            string CompanyName,
            int DailyWage,
            int MaxHrsInMonth,
            int MaxWorkingDaysInMonth,
            int totalEmpWage)
        {
            this.companyName = CompanyName;
            this.dailyWage = DailyWage;
            this.maxHrsInMonth = MaxHrsInMonth;
            this.maxWorkingDaysInMonth = MaxWorkingDaysInMonth;
            this.totalEmpWage = totalEmpWage;

        }
        public override string ToString()
        {
            return "company name : " + this.companyName +
                "daily wage : " + this.dailyWage +
                "max hours in month : " + this.maxHrsInMonth +
                "max working days in month " + this.maxWorkingDaysInMonth +
                "total wage : " + this.totalEmpWage;

        }
    }
}
