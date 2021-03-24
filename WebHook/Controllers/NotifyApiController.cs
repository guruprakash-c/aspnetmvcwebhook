using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebHook.Controllers
{
    [Authorize]
    public class NotifyApiController : ApiController
    {
        public async Task Post()
        {
            await this.NotifyAsync("event2", new { P1 = "p1" });
        }
    }
}
