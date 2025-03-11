using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自訂員工類別
{
    public class EmployeeType1
    {
        // Attribute
        string name; // 姓名
        string id; // 身分證字號
        double sales; // 銷售業績
        double ratio; // 抽傭比例

        // Constrctor
        public EmployeeType1(string name, string id, double sales, double ratio)
        {
            this.name = name;
            this.id = id;
            this.sales = sales;
            this.ratio = ratio;
        }

        // Method

        public string GetName()
        {
            return this.name;
        }
        public string GetId()
        {
            return this.id;
        }
        public double GetTotalSalary()
        {

            return this.sales * this.ratio;
        }
    }
}
