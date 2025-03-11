using System;

namespace s1131375Ex0224_MyDate
{
    internal class MyDateTime : MyDate
    {
        int hour, minute, second;
        public MyDateTime(int year, int month, int day, int hour, int minute, int second) : base(year, month, day)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string GetDateTime()
        {
            string dstr = base.getDate(); // "2024/03/15" , "12:30:00"
            string dtstr = String.Format("{0:d2}:{1:d2}:{2:d2}", hour, minute, second);
            return dstr + " " + dtstr;
        }
    }
}
