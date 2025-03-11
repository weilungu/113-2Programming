using System;

namespace EXC
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---輸入、資料轉換---
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            double[]
                dataO = new double[input1.Length],
                dataA = new double[input2.Length];

            for (int i = 0; i < input1.Length; i++) // string[] TypeCasting => double[]
            {
                dataO[i] = double.Parse(input1[i]);
                dataA[i] = double.Parse(input2[i]);
            }

            // ---設定座標---
            Point O = new Point();
            Point A = new Point();

            O.setXY(dataO[0], dataO[1]);
            A.setXY(dataA[0], dataA[1]);

            double radius = O.distance(A);
            Circle circle = new Circle(O, radius);

            // ---輸出格式---
            string output =
                $"O({O.getX():F1}, {O.getY():F1}) Zone{O.getZone()}\n" +
                $"Radius = {radius:F1}\n" +
                $"Area = {circle.getArea():F1}\n" +
                $"Perimeter = {circle.getPerimeter():F1}";

            Console.WriteLine(output);
        }
    }
    class Point
    {
        private double x;
        private double y;

        public void setXY(double x, double y) // 設定 X、Y 的值
        {
            this.x = x;
            this.y = y;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public int getZone() // 取得象限
        {
            bool xGreater0 = x > 0;
            bool yGreater0 = y > 0;

            if (x == 0 && y == 0) // (0, 0)
            {
                return 0;
            }
            if (xGreater0 && yGreater0) // (+, +)
            {
                return 1;
            }
            else if (!xGreater0 && yGreater0) // (-, +)
            {
                return 2;
            }
            else if (!xGreater0 && !yGreater0) // (-, -)
            {
                return 3;
            }
            else if (xGreater0 && !yGreater0) // (+, -)
            {
                return 4;
            }
            else // (0, 0)
            {
                return 0;
            }
        }
        public double distance(Point p) // this 的距離 ~ p 的距離
        {
            double result = Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));

            return result;
        }
    }

    class Circle
    {
        Point center;
        double radius;
        public Circle(Point center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Point getCenter()
        {
            return center;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            double area = Math.Pow(radius, 2) * Math.PI;

            return area;
        }
        public double getPerimeter()
        {
            double perimeter = 2 * Math.PI * radius;

            return perimeter;
        }
    }
}