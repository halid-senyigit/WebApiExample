using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Controllers
{
    [Route("api/Users")]
    public class UsersController: ControllerBase
    {
        public ActionResult GetAllUsers()
        {
            return null;
        }

    }
}
