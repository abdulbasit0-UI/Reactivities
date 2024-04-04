using System.Diagnostics;
using Application.Activities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;

        }


        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            var activities = await _mediator.Send(new List.Query());
            return Ok(activities);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Activity>> getActivity(Guid id)
        {
            return Ok();
        }


    }
}