using System.Threading;
using System.Threading.Tasks;
using CleanTemplate.Application.Common;
using CleanTemplate.Domain.Entities.Forecasts;
using FluentValidation;
using MediatR;

namespace CleanTemplate.Application.Features.WeatherForecast.Commands
{
    public class AddNewForecastCommand : BaseCqrsRequest<WeatherForecastCreation>
    {
        public AddNewForecastCommand(string appUser)
            : base(appUser)
        {
        }
    }

    internal class AddNewForecastCommandHandler
        : IRequestHandler<AddNewForecastCommand, WeatherForecastCreation>
    {
        private readonly IValidator<WeatherForecastCreation> _validator;

        public AddNewForecastCommandHandler(IValidator<WeatherForecastCreation> validator)
        {
            _validator = validator;
        }

        public Task<WeatherForecastCreation> Handle(AddNewForecastCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult<WeatherForecastCreation>(null);
        }
    }
}
