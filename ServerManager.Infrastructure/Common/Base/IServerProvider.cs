using System.Collections.Generic;
using System.Threading.Tasks;
using ServerManager.Infastructure.Providers.Common.Contracts;
using ServerManager.Infastructure.Providers.Common.Entities;

namespace ServerManager.Infastructure.Common.Base
{
    public interface IServerProvider
    {
        Task<Device> Deploy(AddDeviceRequest request);
        Task<IEnumerable<Facility>> GetFacilities();
        Task<IEnumerable<string>> GetOperatingSystems();
        Task<IEnumerable<Plan>> GetPlans(Facility facility);
    }
}