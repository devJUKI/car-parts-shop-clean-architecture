﻿using Application.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = Roles.Administrator)]
        public IActionResult GetNumbers()
        {
            var numbers = Enumerable.Range(1, 15);
            return Ok(numbers);
        }
    }
}
