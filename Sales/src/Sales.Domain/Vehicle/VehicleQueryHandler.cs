using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Sales.Domain.Vehicle
{
    public class VehicleQueryHandler : IRequestHandler<VehicleQuery, IEnumerable<VehicleResponse>>
    {
        public async Task<IEnumerable<VehicleResponse>> Handle(VehicleQuery request, CancellationToken cancellationToken)
        {
            var vehicles = new List<VehicleResponse>
            {
                new VehicleResponse(){ Registration = "001", Brand = "VW"},
                new VehicleResponse(){ Registration = "002", Brand = "Toyota"}
            };

            return await Task.FromResult(vehicles);
        }
    }
}