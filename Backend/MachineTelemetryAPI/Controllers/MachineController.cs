using MachineTelemetryAPI.DTOs;
using MachineTelemetryAPI.Entities;
using MachineTelemetryAPI.Enums;
using MachineTelemetryAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachineTelemetryAPI.Controllers
{
    [ApiController]
    [Route("api/machine")]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _machineService;

        public MachineController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        [HttpPost]
        public async Task<ActionResult<Machine>> Create([FromBody] MachineCreateDTO machineCreateDTO)
        {
            var newMachine = await _machineService.CreateAsync(machineCreateDTO);
            return Ok(newMachine);
        }

        [HttpPatch]
        public async Task<ActionResult<Machine>> Update([FromBody] MachineUpdateDTO machineUpdateDTO)
        {
            var updatedMachine = await _machineService.UpdateAsync(machineUpdateDTO);
            return Ok(updatedMachine);
        }

        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Machine>>> GetAll()
        {
            var machines = await _machineService.GetAllAsync();

            return Ok(machines);
        }

        [HttpGet("{code:long}")]
        public async Task<ActionResult<Machine>> GetByCode(long code)
        {
            var selectedMachine = await _machineService.GetByCodeAsync(code);

            if (selectedMachine is null)
                return NotFound();

            return Ok(selectedMachine);
        }

        [HttpGet("status/{status}")]
        public async Task<ActionResult<IEnumerable<Machine>>> GetByStatus(Status status)
        {
            var machinesWithSelectedStatus = await _machineService.GetByStatusAsync(status);

            return Ok(machinesWithSelectedStatus);
        }
    }
}