using MachineTelemetryAPI.Enums;

namespace MachineTelemetryAPI.DTOs
{
    public class MachineCreateDTO
    {
        public required string MachineName { get; set; }
        public required Status Status { get; set; }
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
    }
}
