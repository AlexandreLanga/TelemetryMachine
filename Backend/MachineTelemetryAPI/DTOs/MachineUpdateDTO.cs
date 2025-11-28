using MachineTelemetryAPI.Enums;

namespace MachineTelemetryAPI.DTOs
{
    public class MachineUpdateDTO
    {
        public required long Code { get; set; }
        public required Status Status { get; set; }
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
    }
}
