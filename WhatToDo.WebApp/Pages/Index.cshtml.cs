using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WhatToDo.Domain.Entities;
using WhatToDo.Domain.Repositories;

namespace WhatToDo.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ITodoRepository _todoRepository;

    public IndexModel(ILogger<IndexModel> logger, ITodoRepository todoRepository)
    {
        _logger = logger;
        _todoRepository = todoRepository;
    }

    public IEnumerable<Todo> ToDos { get; set; }

    public async Task OnGetAsync()
    {
        ToDos = await _todoRepository.GetAllToDo();
    }
}