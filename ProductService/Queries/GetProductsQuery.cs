using MediatR;
using System.Collections.Generic;

public record GetProductsQuery() : IRequest<List<string>>;