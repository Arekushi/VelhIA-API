using AutoMapper;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhaIA_API.IoC.AutoMapper
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            #region Entity - Request

            CreateMap<Board, BoardRequest>()
                .ReverseMap();

            CreateMap<Column, ColumnRequest>()
                .ReverseMap();

            CreateMap<Line, LineRequest>()
                .ReverseMap();

            CreateMap<Match, MatchRequest>()
                .ReverseMap();

            CreateMap<MatchPlayer, MatchPlayerRequest>()
                .ReverseMap();

            CreateMap<Player, PlayerRequest>()
                .ReverseMap();

            CreateMap<PlayerMove, PlayerMoveRequest>()
                .ReverseMap();

            #endregion

            #region Entity - Response

            CreateMap<Board, BoardResponse>()
                .ReverseMap();

            CreateMap<Column, ColumnResponse>()
                .ReverseMap();

            CreateMap<Line, LineResponse>()
                .ReverseMap();

            CreateMap<Match, MatchResponse>()
                .ReverseMap();

            CreateMap<MatchPlayer, MatchPlayerResponse>()
                .ReverseMap();

            CreateMap<Player, PlayerResponse>()
                .ReverseMap();

            CreateMap<PlayerMove, PlayerMoveResponse>()
                .ReverseMap();

            #endregion
        }
    }
}
