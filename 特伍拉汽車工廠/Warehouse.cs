using System;
using System.Collections;

namespace 特伍拉汽車工廠
{
    internal class Warehouse
    {
        Car[] garage;
        int index = 0, totalCapacity;
        public Warehouse(int nums)
        {
            garage = new Car[nums];
            totalCapacity = nums;
        }

        // Methods
        public void AddCar(Car newCar)
        {
            
            garage[index] = newCar;
            index++;
            totalCapacity--;
        }
        public int GetCapacity()
        {
            return totalCapacity;
        }
        //public int GetTotalCost()
        //{
        //    int totalCost = 0;
        //    foreach (car in garage)
        //    {
        //        totalCost += (int)car.GetCost();
        //    }

        //    return totalCost;
        //}
        //public int GetTotalPrice()
        //{
        //    int totalPrice = 0;
        //    foreach (Car car in garage)
        //    {
        //        totalPrice += (int)car.GetPrice();
        //    }

        //    return totalPrice;
        //}
    }
}
