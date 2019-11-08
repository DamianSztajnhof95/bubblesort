using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bubbleSort.Controllers
{
    public class NumbersController : ApiController
    {
        public string numbers = "";               
        public string Get(string numerki)
        {
            double[] arr = null;
            string[] tokens = numerki.Split(' ');
            try
            {
                arr = Array.ConvertAll<string, double>(tokens, double.Parse);
            }
            catch (System.FormatException)
            {
                return "złe argumenty";
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
            return numbers;
        }   
    }
}
