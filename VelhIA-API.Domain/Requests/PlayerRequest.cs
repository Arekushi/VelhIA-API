using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Requests
{
    public class PlayerRequest : EntityRequest
    {
        public string Name { get; set; }

        public PlayerType Type { get; set; }

        public AlgoritmType? AlgoritmType { get; set; }

        public bool StartPlaying { get; set; }
    }
}
