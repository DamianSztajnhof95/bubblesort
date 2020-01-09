using BubbleSort.Models;
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
            Numbers toSort = new Numbers(numerki);
            return toSort.numbers;
        }
    }
}
