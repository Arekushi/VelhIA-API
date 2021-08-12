using System.Collections.Generic;

namespace VelhIA_API.Domain.Responses
{
    public class BoardResponse : EntityResponse
    {
        public BoardResponse()
        {
            Lines = new List<LineResponse>();
        }

        public ICollection<LineResponse> Lines { get; set; }
    }
}
