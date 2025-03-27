using System;

namespace 特伍拉汽車工廠
{
    public class TestMain
    {
        public class CarMain
        {
            public static void Main(string[] args)
            {
                // 產生倉庫物件
                Warehouse wh = new Warehouse(100);
                // 重複讀取汽車資訊
                String carData = Console.ReadLine();
                while (carData != null && carData.Length > 0)
                {
                    String[] carInfo = carData.Split(' ');
                    // 標準格式：B 1600 manual,「格式不對」就跳過該筆資料！
                    if (carInfo.Length == 3)
                    {
                        char model = (carInfo[0].Length == 0) ? 'X' : carInfo[0][0];
                        // 假如已經沒有資料了...
                        if (model == 'X') break;

                        int cc = int.Parse(carInfo[1]);
                        String aircond = carInfo[2];

                        switch (model)
                        {
                            // HINT: 根據車款種類生成對應的物件，然後加入倉庫內
                            case 'B': // basicCar
                                BasicCar B = new BasicCar(cc, aircond);
                                wh.AddCar(B); break;
                            case 'L':
                                LuxCar L = new LuxCar(cc, aircond);
                                wh.AddCar(L); break;
                            case 'S':
                                SuperLuxCar S = new SuperLuxCar(cc, aircond);
                                wh.AddCar(S); break;
                            default: // 確保不會讓 null 進入 array 中
                                continue; 
                        }
                    }
                    // 讀取下一筆資料
                    carData = Console.ReadLine();
                }
                //
                Console.WriteLine("Total cost: " + wh.GetTotalCost());
                Console.WriteLine("Total price: " + wh.GetTotalPrice());
                Console.WriteLine("Available capacity: " + wh.GetCapacity());
            }
        }
    }
}