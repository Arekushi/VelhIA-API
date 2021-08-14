namespace VelhIA_API.Domain.Responses.Endpoints
{
    public class DoMoveResponse
    {
        public bool Success { get; set; }

        public PlayerResponse NextToPlay { get; set; }

        public BoardResponse Board { get; set; }
    }
}
