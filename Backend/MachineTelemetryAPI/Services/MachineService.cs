using MachineTelemetryAPI.DTOs;
using MachineTelemetryAPI.Entities;
using MachineTelemetryAPI.Enums;
using MachineTelemetryAPI.Interfaces;

namespace MachineTelemetryAPI.Services
{
    public class MachineService : IMachineService
    {
        private static readonly List<Machine> _machines = new List<Machine>();
        private long _nextCode = 1;

        public Task<Machine> CreateAsync(MachineCreateDTO machineCreateDTO)
        {
            Machine newMachine = new Machine() 
            { 
                Code = _nextCode++,
                MachineName = machineCreateDTO.MachineName,
                Status = machineCreateDTO.Status,
                Latitude = machineCreateDTO.Latitude,
                Longitude = machineCreateDTO.Longitude
            };

            _machines.Add(newMachine);
            return Task.FromResult(newMachine);     
        }

        public Task<Machine?> UpdateAsync(MachineUpdateDTO machineUpdateDTO)
        {
            var machine = _machines.FirstOrDefault(machine => machine.Code == machineUpdateDTO.Code);

            if (machine is null)
                return Task.FromResult<Machine?>(null);

            machine.Status = machineUpdateDTO.Status;
            machine.Latitude = machineUpdateDTO.Latitude;
            machine.Longitude = machineUpdateDTO.Longitude;

            return Task.FromResult<Machine?>(null!);
        }

        public Task<IEnumerable<Machine>> GetAllAsync()
        {
            return Task.FromResult(_machines.AsEnumerable());
        }

        public Task<IEnumerable<Machine>> GetByStatusAsync(Status status)
        {
            var machinesWithSelectedStatus = _machines.Where(machine => machine.Status == status);
            return Task.FromResult(machinesWithSelectedStatus);
        }

        public Task<Machine?> GetByCodeAsync(long code)
        {
            var selectedMachine = _machines.FirstOrDefault(machine => machine.Code == code);

            return Task.FromResult(selectedMachine);
        }
    }
}