using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CleanTemplate.Application.Features.Forecast.Queries;

namespace CleanTemplate.WebUI.Controllers.Features.Weather
{
    [Route("[controller]")]
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IQueryable<WeatherForecastContract>>> Get(string location)
        {
            var action = new GetAllForecastForLocationQuery(User?.Identity?.Name, location);
            var result = await Mediator.Send(action);

            //mapping

            return Ok(result);
        }
    }
}
