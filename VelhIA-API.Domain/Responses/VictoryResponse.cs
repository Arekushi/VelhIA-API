namespace VelhIA_API.Domain.Responses
{
    public class VictoryResponse
    {
        public string Type { get; set; }

        public ResultResponse Result { get; set; }

        public PlayerResponse Winner { get; set; }

        public PlayerResponse Loser { get; set; }
    }
}
