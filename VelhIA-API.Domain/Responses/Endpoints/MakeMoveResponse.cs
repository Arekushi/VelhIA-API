namespace VelhIA_API.Domain.Responses.Endpoints
{
    public class MakeMoveResponse
    {
        public bool Success { get; set; }

        public PlayerResponse NextToPlay { get; set; }
    }
}
