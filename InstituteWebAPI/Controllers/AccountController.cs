using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Institute.Common.DTOs.Account;
using LoginRequest = Institute.Common.DTOs.Account.LoginRequest;
using Institute.Common.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Institute.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        // GET: api/<AccountController>
        //[HttpGet]
        //public IEnumerable<AccountController> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<AccountController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<AccountController>
        [HttpPost(Name ="Login")]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            var response =await _accountService.VerifyLoginDetails(request);

            return response;
        }

        //// PUT api/<AccountController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<AccountController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
