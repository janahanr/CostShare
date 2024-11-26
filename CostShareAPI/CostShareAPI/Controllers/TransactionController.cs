using System;
using Microsoft.AspNetCore.Mvc;

namespace CostShareAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController
{
    [HttpGet(Name = "Transaction/{id}")]
    public IEnumerable<Transaction> Get(int id)
    {

    }
}