using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocGenTest.Models;

namespace SocGenTest.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountZeroAndOneController : ControllerBase
    {
        private static readonly List<int> intArray = new List<int>
        {
            0, 1, 2, 1, 1, 0, 0, 1, 3, 0, 11, 5, 0, 1, 0, 0, 0, 1, 1
        };

        [Route("")]
        [Route("/")]
        [HttpGet]
        public CountZeroAndOne CountZeroAndOne()
        {
            try
            {
                CountZeroAndOne count = new CountZeroAndOne();
                foreach (int i in intArray)
                {
                    if (i == 0)
                        count.ZeroCount++;
                    else if (i == 1)
                        count.OneCount++;
                }
                return count;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

