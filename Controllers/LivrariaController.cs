using GestaoLivraria.Requests;
using GestaoLivraria.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivrariaController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Livros), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterLivros), StatusCodes.Status200OK)]
    public IActionResult Get(int id)
    {
        return Ok();
    }


    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterLivros), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterLivrosJson request)
    {
        var response = new ResponseRegisterLivros
        {
            Id = request.Id,
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price,
            Quantity = request.Quantity
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id,[FromBody] RequestUpdateLivroJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
