using Microsoft.AspNetCore.Mvc;

namespace FlowersApi.Controllers
{
    [ApiController]
    [Route("Flowers/[action]")]
    public class FlowersController: ControllerBase
    {
        public string Rose()
        {
            return "Rose";
        }
        public string Orchid()
        {
            return "Orchid";
        }
        public string Daisy()
        {
            return "Daisy";
        }
        public string Iris()
        {
            return "Iris";
        }
    }
}
