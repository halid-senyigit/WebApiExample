using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.DataTransferObjects;

namespace WebApiExample.Controllers
{
    [Route("api/Users")]
    public class UsersController: ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersController(
            IUsersRepository usersRepository,
            IMapper mapper
            )
        {
            this._usersRepository = usersRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var usersFromRepo = _usersRepository.GetAll();
            var usersMapped = _mapper.Map<IEnumerable<UserDTO>>(usersFromRepo);
            return Ok(usersMapped);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var userFromRepo = _usersRepository.GetById(id);
            var userMapped = _mapper.Map<UserDTO>(userFromRepo);
            return Ok(userMapped);
        }

    }
}
