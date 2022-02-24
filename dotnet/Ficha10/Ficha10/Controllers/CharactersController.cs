using FREQ_2019419;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Text.Json;

namespace Ficha10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private Characters characters;

        public CharactersController()
        {
            characters = JsonLoader.DeserializeCharacters();
        }

        // Listar todos os funcionários existentes no ficheiro e devolver os mesmos na resposta
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return characters.CharactersList;
        }

        // Selecionar apenas um funcionário pelo seu ID e devolver esse mesmo funcionário na resposta
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var c = characters.CharactersList.Find(c => c.Id == id);
            return c != null ? Ok(c) : NotFound();
        }

        [HttpGet("{gender}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string gender)
        {
            var c = characters.CharactersList.FindAll(c => c.Gender == gender.ToLower());
            return c != null ? Ok(c) : NotFound();
        }

        [HttpGet("/Characters/Jedi")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetJedi()
        {
            var c = characters.CharactersList.FindAll(c => c.Jedi);
            return c != null ? Ok(c) : NotFound();
        }

        // Efetuar download da lista atual de funcionários como um ficheiro .json
        [HttpGet("/Characters/Download")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetDownload()
        {
            System.IO.File.WriteAllText("characters.json", JsonSerializer.Serialize(characters));
            return File(System.IO.File.ReadAllBytes("characters.json"), "application/json", "test.json");
        }


        // Adicionar um novo funcionário, o ID deve ser gerado automaticamente tendo em conta o número de funcionários existentes.
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Character c)
        {
            if (characters.CharactersList.Count == 0)
            {
                c.Id = 1;
            }
            else
            {
                c.Id = characters.CharactersList.Last().Id + 1;
            }

            characters.CharactersList.Add(c);
            return Created("characters/" + c.Id, c);
        }

        // Apagar um funcionário pelo seu ID
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int id, [FromBody] Character putChar)
        {
            Character c = characters.CharactersList.Find(c => c.Id == id);

            if (c != null)
            {
                c.Name = putChar.Name;
                c.Gender = putChar.Gender;
                c.Homeworld = putChar.Homeworld;
                c.Born = putChar.Born;
                c.Jedi = putChar.Jedi;

                return Ok(c);
            }
            else
            {
                return NotFound();
            }
        }

        // Alterar os detalhes de um determinado funcionário pelo seu ID
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Character))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            int r = characters.CharactersList.RemoveAll(c => c.Id == id);
            return r > 0 ? Ok(id) : NotFound();
        }
    }
}
