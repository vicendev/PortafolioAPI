using Microsoft.AspNetCore.Mvc;
using Org.Sdt.Architecture.Core.Repository;
using Org.Sdt.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Portafolio.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMongoRepository<UserEntity> _genericUserRepository;

        public UsersController(
            IMongoRepository<UserEntity> genericUserRepository)
        {
            _genericUserRepository = genericUserRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _genericUserRepository.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserEntity>> GetById(string id)
        {
            var user = await _genericUserRepository.GetById(id);

            return Ok(user);
        }

        [HttpPost]
        public async Task Post(UserEntity user)
        {
            await _genericUserRepository.InsertDocument(user);
        }

        [HttpPut]
        public async Task Update(UserEntity user)
        {
            await _genericUserRepository.UpdateDocument(user);
        }
    }
}
