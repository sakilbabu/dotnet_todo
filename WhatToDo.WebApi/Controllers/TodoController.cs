using Microsoft.AspNetCore.Mvc;
using WhatToDo.Domain.Repositories;

namespace WhatToDo.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoRepository _todoRepository;

    public TodoController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
        
    [HttpGet]
    public async Task<IActionResult> GetAllTodo()
    {
        return Ok(await _todoRepository.GetAllToDo());
    }
}