using System.Collections.Generic;

namespace VelhIA_API.Domain.Requests
{
    public class BoardRequest : EntityRequest
    {
        public BoardRequest()
        {
            Lines = new List<LineRequest>();
        }

        public ICollection<LineRequest> Lines { get; set; }
    }
}
