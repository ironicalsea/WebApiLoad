using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiLoad.Controllers
{
    public class JsonController : ApiController
    {
        [HttpPost]
        public async Task<object> Post()
        {
            var body = await Request.Content.ReadAsStringAsync().ConfigureAwait(false);

            var val = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(body);
            return  val;
        }
    }
}