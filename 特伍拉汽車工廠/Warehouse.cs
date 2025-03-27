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
        public int GetTotalCost()
        {
            int cost = 0;
            foreach(Car car in garage)
            {
                if(car != null)
                {
                    cost += car.GetCost();
                }
            }
            return cost;
        }
        public int GetTotalPrice()
        {
            int price = 0;
            foreach(Car car in garage)
            {
                if (car != null)
                {
                    price += car.GetPrice();
                }
            }
            return price;
        }
    }
}
