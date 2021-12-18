using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Odev4_API.Controllers
{

    public class BaseController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public BaseController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
    }
}
