using Intranet.Interview.Domain.DataForm;
using MediatR;
using System.Text.Json.Serialization;

namespace Intranet.Interview.Application.DataForm.Commands;

/// <summary>
/// Save Form Data
/// </summary>
/// <param name="Name"></param>
/// <param name="Email"></param>
/// <param name="Age"></param>
/// <param name="Industry"></param>
/// <param name="SubscribeToNewsletter"></param>
public record AddFormCommand(string JsonData) : IRequest;

