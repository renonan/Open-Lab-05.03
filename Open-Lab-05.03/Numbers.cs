using System;
using System.Globalization;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string result = string.Format("{0:n0}", num);
            return result;

        }
    }
}
