using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services.Cars.Queries;
using Services.Models;

namespace MediatRWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // public Task<IEnumerable<Car>> Index([FromBody] GetAllCarsQuery query)
        // {
        //     return _mediator.Send(query);
        // }
        
        public Task<IEnumerable<Car>> Index()
        {
            return _mediator.Send(new GetAllCarsQuery());
        }
    }
}