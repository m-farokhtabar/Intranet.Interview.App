using Intranet.Interview.Application.DataForm.Commands;
using Intranet.Interview.Application.DataForm.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Interview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormDataController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<FormDataController> logger;        

        public FormDataController(IMediator mediator, ILogger<FormDataController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;            
        }
        /// <summary>
        /// Save form data
        /// </summary>
        /// <param name="userIdentifier"></param>
        /// <returns>Avatar url address</returns>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] dynamic jsonData)
        {
            string jsonString = Convert.ToString(jsonData);
            await mediator.Send(new AddFormCommand(jsonString));
            return NoContent();
        }
        /// <summary>
        /// Get form meta data
        /// </summary>
        /// <returns></returns>
        [HttpGet("MetaData/{FormId}")]
        public async Task<IActionResult> MetaData(Guid FormId)
        {
            return Ok(await mediator.Send(new MetaFormQuery(FormId)));
        }
    }
}
