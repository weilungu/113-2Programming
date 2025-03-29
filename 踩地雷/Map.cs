using System;

namespace 踩地雷
{
    internal class Map
    {
        int size;
        char emptyElement, landminesElement;
        public Map(int size)
        {
            this.size = size;
            this.emptyElement = '_';
            this.landminesElement = '*';
        }

        public string Creat()
        {
            string map = "";
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    map += emptyElement;
                }
                if(i == size - 1) { break; }
                map += '\n';
            }
            return map;
        }
        public string SetLandmines(string map, int input_i, int input_j)
        {
            string[] newMap = map.Split('\n');
            char[,] coordinate = new char[size, size];
            for (int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    coordinate[i, j] = newMap[i].ToCharArray()[j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    bool Delivery = i == input_i-1 && j == input_j-1; // 是否要投放地雷
                    if( Delivery)
                    {
                        coordinate[i, j] = landminesElement;
                    }
                }
            }

            // 合併
            string result = "";
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    result += coordinate[i, j];
                }
                result += "\n";
            }

            return result;
        }
    }
}
