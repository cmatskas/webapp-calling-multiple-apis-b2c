﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi1.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet("GetPublic")]
		public string GetPublic()
		{
			return $"Response from PUBLIC method of WebApi1 test controller at {DateTime.UtcNow} (UTC)";
		}

		[Authorize]
		[HttpGet("GetProtected")]
		public ActionResult<string> GetProtected()
		{
			return Ok($"Response from PRIVATE method of WebApi1 test controller at {DateTime.UtcNow} (UTC)");
		}
	}
}
