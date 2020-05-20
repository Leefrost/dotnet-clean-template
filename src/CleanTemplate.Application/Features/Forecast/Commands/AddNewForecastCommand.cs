using System.Threading;
using System.Threading.Tasks;
using CleanTemplate.Application.Common;
using CleanTemplate.Domain.Entities.Forecasts;
using MediatR;

namespace CleanTemplate.Application.Features.Forecast.Commands
{
    public class AddNewForecastCommand : BaseCqrsRequest<WeatherForecastCreation>
    {
        public AddNewForecastCommand(string appUser, WeatherForecastCreation creationData)
            : base(appUser)
        {
            CreationData = creationData;
        }

        public WeatherForecastCreation CreationData { get; }

    }

    internal class AddNewForecastCommandHandler
        : IRequestHandler<AddNewForecastCommand, WeatherForecastCreation>
    {

        public AddNewForecastCommandHandler()
        {
        }

        public Task<WeatherForecastCreation> Handle(AddNewForecastCommand request, CancellationToken cancellationToken)
        {

            return Task.FromResult<WeatherForecastCreation>(null);
        }
    }
}
