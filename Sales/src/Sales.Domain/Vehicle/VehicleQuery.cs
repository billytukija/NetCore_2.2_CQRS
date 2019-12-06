using MediatR;
using System.Collections.Generic;

namespace Sales.Domain.Vehicle
{
    public class VehicleQuery : IRequest<IEnumerable<VehicleResponse>>
    {
        public string Registration { get; }

        public VehicleQuery(string registration)
        {
            Registration = registration;
        }
    }
}
