using JsonStorager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace JsonStorager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRelationsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return Helper.ReadJson(Constants.JSON_USER_RELATIONS);
        }
        [HttpPost]
        [Consumes("text/plain")]
        public string Post([FromBody] string content)
        {
            if (content != null && content.Length > 0)
            {
                Helper.WriteJson(Constants.JSON_USER_RELATIONS, content);
            }
            return "We received this:\n" + content;
        }
    }
}
