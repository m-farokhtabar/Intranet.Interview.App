using Intranet.Interview.API.StartupConfig;
using Intranet.Interview.Application.DataForm.Commands;
using Intranet.Interview.Application.DataForm.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Interview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<PersonController> logger;
        private readonly ApplicationSettings settings;

        public PersonController(IMediator mediator, ILogger<PersonController> logger, ApplicationSettings settings)
        {
            this.mediator = mediator;
            this.logger = logger;
            this.settings = settings;
        }
        /// <summary>
        /// Save Person Data
        /// </summary>
        /// <param name="userIdentifier"></param>
        /// <returns>Avatar url address</returns>
        [HttpPost]
        public async Task<IActionResult> Add(AddPersonCommand person)
        {
            await mediator.Send(person);
            return NoContent();
        }
        /// <summary>
        /// Get Person form meta data
        /// </summary>
        /// <returns></returns>
        [HttpGet("MetaData")]
        public async Task<IActionResult> MetaData()
        {
            return Ok(await mediator.Send(new MetaFormQuery(settings.PersonFormId)));
        }
    }
}
