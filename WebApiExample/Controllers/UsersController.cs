using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Controllers
{
    [Route("api/Users")]
    public class UsersController: ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(
            IUsersRepository usersRepository
            )
        {
            this._usersRepository = usersRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_usersRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_usersRepository.GetUserById(id));
        }

    }
}
