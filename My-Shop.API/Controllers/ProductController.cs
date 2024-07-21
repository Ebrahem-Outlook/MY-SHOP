using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace My_Shop.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public sealed class ProductController(ISender sender) : ControllerBase
{

}
