using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDG.OpsPlateform.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AWXJobsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AWXJobsController> _logger;

        public AWXJobsController(ILogger<AWXJobsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public object Get()
        {
            var client = new RestClient("http://10.198.102.140/api/v2/jobs/455/job_host_summaries/");
            var request = new RestRequest();
            request.AddHeader("Authorization", "Basic ZWFrYXNhay5waWI6Ykd2aE1wMlhXa3RrVzY2aGtjalYjJCU=");
            var response = client.ExecuteGetAsync(request).Result;
            Console.WriteLine(response.Content);

            return response.Content;
        }

       /* [HttpGet]
        public object GetById(int id)
        {
            var client = new RestClient("http://10.198.102.140/api/v2/jobs/"+ id +"job_host_summaries");
            var request = new RestRequest();
            request.AddHeader("Authorization", "Basic ZWFrYXNhay5waWI6Ykd2aE1wMlhXa3RrVzY2aGtjalYjJCU=");
            var response = client.ExecuteGetAsync(request).Result;
            Console.WriteLine(response.Content);

            return response.Content;
        }*/
    }
}
