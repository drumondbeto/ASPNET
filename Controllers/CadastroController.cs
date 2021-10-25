using System;
using System.Collections.Generic;
using ASPNET.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        //POST api/cadastro
        public ActionResult<IEnumerable<string>> CadastrarNovoUsuario(Users)
        {
            using var db = new Data.ApplicationContext();
            db.Set<Users>().Add(newUser);
            db.SaveChanges();
        }
    }
}