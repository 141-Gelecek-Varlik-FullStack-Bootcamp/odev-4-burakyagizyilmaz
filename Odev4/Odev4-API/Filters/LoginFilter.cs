using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Odev4_Data.DTOs;
using Odev4_Data.Models;
using System;

namespace Odev4_API.Filters
{
    public class LoginFilter : Attribute, IActionFilter
    {
        private readonly IMemoryCache _memoryCache;

        public LoginFilter(IMemoryCache memoryCache, AppDBContext dbContext)
        {
            _memoryCache = memoryCache;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!_memoryCache.TryGetValue(CacheKey.LoginKey, out UserLoginDTO userLogin))
            {
                context.Result = new UnauthorizedObjectResult("Yetkisiz Erişim");
            }
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
