using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace P51_CSharp
{
    public static class ExtensionMethod
    {
        public static string MultString(this string message, int n)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                builder.Append(message);
            }
            return builder.ToString();
        }

        public static string PadLeftRight(this string message, int widht)
        {
            int sp = widht - message.Length;
            if(sp > 0)
            {
                int sp_l = sp / 2;
                int sp_r = sp - sp_l;
                return " ".MultString(sp_l) + message + " ".MultString(sp_r);
            }
            return message;
        }
    }
}
