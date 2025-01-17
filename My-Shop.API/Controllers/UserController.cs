﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using My_Shop.API.Contracts;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Application.Users.Commands.UpdateEmail;
using My_Shop.Application.Users.Commands.UpdateUser;
using My_Shop.Application.Users.Queries.GetAllUsers;
using My_Shop.Application.Users.Queries.GetByEmail;
using My_Shop.Application.Users.Queries.GetById;
using My_Shop.Application.Users.Queries.GetByName;

namespace My_Shop.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public sealed class UserController(ISender sender) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRequest request) =>
        Ok(await sender.Send(
            new CreateUserCommand(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.Password)));

    [HttpPut]
    public async Task<IActionResult> Update(UpdateUserRequest request) =>
        Ok(await sender.Send(
            new UpdateUserCommand(
                request.UserId,
                request.FirstName,
                request.LastName)));

    [HttpPut("email")]
    public async Task<IActionResult> UpdateEmail(UpdateEmailRequest request) =>
        Ok(await sender.Send(
            new UpdateEmailCommand(
                request.UserId,
                request.Email)));

    [HttpPut("password")]
    public async Task<IActionResult> UpdatePassword(UpdatePasswordRequest request) =>
        Ok(await sender.Send(
            new UpdateEmailCommand(
                request.UserId,
                request.Password)));

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await sender.Send(new GetAllUsersQuery()));

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id) => Ok(await sender.Send(new GetByIdQuery(id)));

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmail(string email) => Ok(await sender.Send(new GetByEmailQuery(email)));

    [HttpGet("name")]
    public async Task<IActionResult> GetByName(string name) => Ok(await sender.Send(new GetByNameQuery(name)));
}
