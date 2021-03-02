using CtasPagarAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CtasPagarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        public IConfiguration _configuration;
        private readonly AppDbContext _context;

        public TokenController(IConfiguration config, AppDbContext context)
        {
            _configuration = config;
            _context = context;
        }               

    }
}
