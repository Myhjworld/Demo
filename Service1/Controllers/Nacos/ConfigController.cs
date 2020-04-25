using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nacos;

namespace Service1.Controllers.Nacos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigController:ControllerBase
    {
        private readonly INacosConfigClient _configClient;

        public ConfigController(INacosConfigClient configClient)
        {
            _configClient = configClient;
        }

        // GET api/config?key=demo1
        [HttpGet("")]
        public async Task<string> Get([FromQuery]string key)
        {
            var res = await _configClient.GetConfigAsync(new GetConfigRequest
            {
                DataId = key,
                Group = "DEFAULT_GROUP",
                //Tenant = "tenant"
            }) ;

            return string.IsNullOrWhiteSpace(res) ? "Not Found" : res;
        }

        // GET api/config/add?key=demo1&value=123
        [HttpGet("add")]
        public async Task<string> Add([FromQuery]string key, [FromQuery]string value)
        {
            var res = await _configClient.PublishConfigAsync(new PublishConfigRequest
            {
                DataId = key,
                Group = "DEFAULT_GROUP",
                //Tenant = "tenant"
                Content = value
            });

            return res.ToString();
        }
    }
}