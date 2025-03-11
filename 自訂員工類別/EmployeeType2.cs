using System;
using 自訂員工類別;

namespace 自訂員工類別
{
    class EmployeeType2 : EmployeeType1
    {
        string name, id;
        double sales, ratio, baseSalary;

        public EmployeeType2(string name, string id, double sales, double ratio, double baseSalary) : base(name, id, sales, ratio)
        {
            this.name = name;
            this.id = id;
            this.sales = sales;
            this.ratio = ratio;
            this.baseSalary = baseSalary;
        }

        public double GetTotalSalary()
        {
            return (this.sales * this.ratio) + this.baseSalary;
        }
        public double GetBaseSalary(double baseSalary)
        {
            return baseSalary;
        }
    }
}
