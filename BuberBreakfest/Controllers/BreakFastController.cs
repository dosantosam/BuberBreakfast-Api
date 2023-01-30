using BuberBreakFest.Contracts.BreakFest;
using Microsoft.AspNetCore.Mvc;
using BuberBreakfest.Models;
using BuberBreakfest.Services.Breakfasts;
namespace BuberBreakfest.Controllers;


[ApiController]
[Route("breakfasts")]
public class BreakFastsController : ControllerBase
{

    private readonly IBreakfastService _breakfastService;

    public BreakFastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    } 

    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakFastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        //TODO : save breakfast to database
        _breakfastService.CreateBreakfast(breakfast);

        var response = new BreakFastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);

        return CreatedAtAction(
            nameof(GetBreakfast),
            new { id = breakfast.Id },
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        Breakfast breakfast = _breakfastService.GetBreakfast(id);

         var response = new BreakFastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakFast(Guid id, UpsertBreakFastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }

}