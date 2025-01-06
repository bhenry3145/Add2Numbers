using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers : ControllerBase
    {
        public List<string> sum = new();

        [HttpPost]
        [Route("Add2Numbers/{num1}/{num2}")]

        public List<string> AddNumbers(int num1, int num2)
        {
            string sentence = "The sum of " + num1.ToString() + " and " + num2.ToString() + " is equal to " + (num1 + num2).ToString();
            sum.Add(sentence);
            return sum;
        }

    }
}