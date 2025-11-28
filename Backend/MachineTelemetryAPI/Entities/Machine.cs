using MachineTelemetryAPI.Enums;

namespace MachineTelemetryAPI.Entities
{
    public class Machine
    {
        public required long Code { get; set; }
        public required string MachineName { get; set; }
        public required Status Status { get; set; }
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
    }
}