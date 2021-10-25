using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()  // RECOMENDADO. Permite o retorno de Results e valores conversiveis para string.
        {
            var valores = new string[] { "value1", "value2"};

            if (valores.Length < 5000)
            return BadRequest();

            return valores;
        }

        public IEnumerable<string> GetItAll()  // Nao permite o retorno de Results, apenas valores conversiveis para string
        {
            var valores = new string[] { "value1", "value2"};

            if (valores.Length < 5000)
                return null;

            return valores;
        }

        [HttpGet]
        public ActionResult GetAll() // Permite que seja retornado apenas Results
        {
            var valores = new string[] { "value1", "value2"};

            if (valores.Length < 5000)
            return BadRequest();

            return Ok(valores); 
        }


        // GET api/values/obter-po-id/5
        [HttpGet("obter-por-id/{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post(Product product)
        {
            if (product.Id == 0) return BadRequest();

            // add no banco

            //return Ok(product);
            return CreatedAtAction(nameof(Post), product);  // 201
        }

        [HttpPost]
        public void PostIt([FromBody] Product product)  
        // Quando passamos como parametro algo do tipo complexo (objetos, por exemplo), 
        // o [FromBody] eh implicito, nao somos obrigados a declara-lo neste caso.
        {
        }

        // PUT api/values/5
        [HttpPut("{id")]
        //public void Put([FromRoute] int id, [FromBody] Product value)     
        // [FromRoute] esta implicito, uma vez q a variavel possui o msm nome na rota e no constructor.
        public void Put( int id, [FromForm] Product value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromQuery] int id)
        {
        }
    }

    public class Product
    {
        public int Id { get; set;}

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}