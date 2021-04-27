using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Services.Cars.Commands
{
    public class CreateCarCommand : IRequest<string>
    {
        
    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, string>
    {
        public Task<string> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}