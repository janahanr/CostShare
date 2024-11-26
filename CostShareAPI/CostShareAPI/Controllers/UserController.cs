using System;
using Microsoft.AspNetCore.Mvc;

namespace CostShareAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    [HttpGet(Name = "User/{id}")]
    public IEnumerable<User> Get(int id)
	{
        
	}
}
