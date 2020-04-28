using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeandroCurioso.EntityFrameworkCore.Poc.Models;
using LeandroCurioso.EntityFrameworkCore.Poc.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LeandroCurioso.EntityFrameworkCore.Poc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(
            IUserRepository userRepository,
            ILogger<UserController> logger
        )
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        [HttpPost]
        public async Task Create()
        {
            var user = new User()
            {
                Name = "Leandro",
                Email = "leandro.curioso@gmail.com"
            };
            await _userRepository.Create(user);
        }
    }
}
