using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class GetProductsQueryHandler
    : IRequestHandler<GetProductsQuery, List<string>>
{
    public Task<List<string>> Handle(
        GetProductsQuery request,
        CancellationToken cancellationToken)
    {
        var products = new List<string>
        {
            "Life Insurance",
            "Car Insurance",
            "Health Insurance"
        };

        return Task.FromResult(products);
    }
}