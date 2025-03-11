using System;

namespace s1131375Ex0224_MyDate
{
    public class MyDate : Object
    {
        // fields
        private int year;
        private int month;
        private int day;

        //
        public MyDate()
        {
            setDate(2000, 1, 1);
        }
        public MyDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        //
        // New public methods
        public void setDate(int y, int m, int d)
        {
            this.year = y;
            this.month = m;
            this.day = d;
        }
        public int getYear()
        {
            return this.year;
        }
        public int getMonth()
        {
            return this.month;
        }
        public int getDay()
        {
            return this.day;
        }
        public String getDate()
        {
            return String.Format("{0:d4}/{1:d2}/{2:d2}", year, month, day);
        }

    }
}
