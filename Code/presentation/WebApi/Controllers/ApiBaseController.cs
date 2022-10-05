﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Code.WebApi.Controllers;

public class ApiBaseController : ControllerBase
{
    private ISender _mediator = null;
    public ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
