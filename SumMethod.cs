using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_DaniyalRaza
{
    public class SumMethod
    {
        int sum1 = 0;
        public int sum(int sum1)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 5 };
            int[] arr2 = { 3, 6, 8, 9 };
            int[] arr3 = { 1, 2, 3, 4 };
            for(int i=0; i<arr1.Length; i++)
            {
                for(int j=0; j < arr2.Length; j++)
                {
                    for(int k=0; k<arr3.Length; k++)
                    {
                       
                        sum1 = sum1 + arr1[i];
                    }
                }
            }
            return sum1;
        }
    }
}
