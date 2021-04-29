using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Services.Models;

namespace Services.Cars.Commands
{
    public class CreateCarCommand : IRequest<Response<Car>>
    {
        
    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Response<Car>>
    {
        public Task<Response<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            if (false)
                return Task.FromResult(Response.Fail<Car>("already exists"));

            return Task.FromResult(Response.Ok(new Car{Name = "Mazda"}, "Car created"));
        }
    }
}