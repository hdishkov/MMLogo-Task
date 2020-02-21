using System;
using System.Collections.Generic;
using System.Text;

namespace MMLogo
{
    public static class PrintLogo
    {
        public static StringBuilder Print(int num)
        {
            StringBuilder sb = new StringBuilder();

            //Upper half
            for (int i = 0; i <= num / 2; i++)
            {
                //First M
                sb.Append(new string('-', num - i));
                sb.Append(new string('*', num + i));
                sb.Append(new string('*', i));
                sb.Append(new string('-', num - i - i));
                sb.Append(new string('*', num + i));
                sb.Append(new string('*', i));
                sb.Append(new string('-', num - i));
                //Second M
                sb.Append(new string('-', num - i));
                sb.Append(new string('*', num + i));
                sb.Append(new string('*', i));
                sb.Append(new string('-', num - i - i));
                sb.Append(new string('*', num + i));
                sb.Append(new string('*', i));
                sb.Append(new string('-', num - i));

                sb.AppendLine();
            }

            //Bottom half
            for (int j = num / 2; j >= 0; j--)
            {
                //First M
                sb.Append(new string('-', j));
                sb.Append(new string('*', num));
                sb.Append(new string('-', num - j - j));
                sb.Append(new string('*', num + j));
                sb.Append(new string('*', j));
                sb.Append(new string('-', num - j - j));
                sb.Append(new string('*', num));
                sb.Append(new string('-', j));
                //Second M
                sb.Append(new string('-', j));
                sb.Append(new string('*', num));
                sb.Append(new string('-', num - j - j));
                sb.Append(new string('*', num + j));
                sb.Append(new string('*', j));
                sb.Append(new string('-', num - j - j));
                sb.Append(new string('*', num));
                sb.Append(new string('-', j));

                sb.AppendLine();
            }

            return sb;

        }
    }
}
