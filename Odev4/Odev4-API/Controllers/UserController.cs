using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Odev4_Data.DTOs;
using Odev4_Data.Models;
using System;
using System.Linq;


namespace Odev4_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IMemoryCache _memoryCache;
        private readonly AppDBContext _dbContext;

        public UserController(IMemoryCache memoryCache, AppDBContext dbContext) : base(memoryCache)
        {
            _dbContext = dbContext;
            _memoryCache = memoryCache;
        }

        [HttpPost]
        public IActionResult Login([FromBody]UserLoginDTO userLogin)
        {

            if (string.Equals(userLogin.Password,userLogin.PasswordConfirmation)) //Şifrelerin aynı olup olmadığı kontrol edildi.
            {
                if (_dbContext.Users.Any(x => x.Email == userLogin.Email && x.Password == userLogin.Password)) // Kullanıcı maili ve şifresi ile uyuşan user var mı diye bakıldı.
                {
                    //Kullanıcı bilgisi Memorycache e atıldı.
                    _memoryCache.Set(CacheKey.LoginKey, userLogin, new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddDays(1),
                        Priority = CacheItemPriority.High
                    });
                    return Ok("Giriş Yapıldı");
                }
                else
                {
                    return BadRequest("Hatalı bilgi girdiniz.");
                }
            }
            else
            {
                return BadRequest("Şifreler uyumlu değil.");
            }
        }
    }
}
