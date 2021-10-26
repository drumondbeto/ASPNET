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
        [HttpPost]
        public ActionResult<IEnumerable<string>> CadastrarNovoUsuario(/*[FromBody] Users newUser*/)
        {
            using var db = new Data.ApplicationContext();

            var user = new Users
            {
                Nome = "Maicon Douglas",
                Email = "md@md.com",
                Senha = "nuncamaiseuvoudormir"
            };

            db.Set<Users>().Add(user);
            db.SaveChanges();
            return Ok();
        }
    }
}