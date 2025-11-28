using MachineTelemetryAPI.DTOs;
using MachineTelemetryAPI.Entities;
using MachineTelemetryAPI.Enums;

namespace MachineTelemetryAPI.Interfaces
{
    public interface IMachineService
    {
        Task<IEnumerable<Machine>> GetAllAsync();
        Task<IEnumerable<Machine>> GetByStatusAsync(Status status);
        Task<Machine?> GetByCodeAsync(long code);
        Task<Machine> CreateAsync(MachineCreateDTO dto);
        Task<Machine?> UpdateAsync(MachineUpdateDTO dto);
    }
}