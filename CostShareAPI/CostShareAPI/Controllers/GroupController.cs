using System;
using Microsoft.AspNetCore.Mvc;

namespace CostShareAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GroupController
{
    [HttpGet(Name = "Group/{id}")]
    public IEnumerable<Group> Get(int id)
    {

    }
}