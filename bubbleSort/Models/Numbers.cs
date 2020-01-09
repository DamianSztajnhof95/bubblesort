using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BubbleSort.Models
{
    public class Numbers
    {

        public string numbers = "";
        public Numbers(string numerki)
        {
            double[] arr = null;
            string[] tokens = numerki.Split(' ');
            try
            {
                arr = Array.ConvertAll<string, double>(tokens, double.Parse);
            }
            catch (System.FormatException)
            {
                numbers = "złe argumenty";
            }
            double temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            numbers = string.Join(" ", arr);

        }
    }
}