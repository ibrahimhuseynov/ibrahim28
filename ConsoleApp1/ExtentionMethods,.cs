using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class ExtentionMethods_
    {
        public static bool IsOdd(double Number)
        {
            if (Number % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(double Number)
        {
            if(Number % 2 == 0)
            {
                return true ;
            }
            return false ;
        }
        public static bool IsContainsDigit(string HasDight)
        {
            for (int i = 0; i < HasDight.Length; i++)
            {
                if (char.IsDigit(HasDight[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string UserName)
        {
          foreach (char item in UserName)
            {
                if(!char.IsDigit(item))
                {
                    return UserName;
                } 
               
            }
            return null;
        }
        public static int GetValueIndexes(this string Name, char search)
        {
            int[] cheang = new int[0];
           for (int i = 0; i < Name.Length; i++)
            {
                if(Name[i] == search)
                {
                    Array.Resize(ref cheang, cheang.Length + 1);
                    cheang[cheang.Length - 1] = i;
                }
            return cheang[i];
            }
            return 0;
        }

    }
}
