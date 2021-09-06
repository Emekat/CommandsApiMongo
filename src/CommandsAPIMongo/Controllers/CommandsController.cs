using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsAPIMongo.Models;
using CommandsAPIMongo.Data;

namespace CommandsAPIMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //Add the following code to our class
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             var commandItems = _repository.GetAllCommands();
             return Ok(commandItems);
        }

        //Add the following code for our second ActionResult
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(string id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}
