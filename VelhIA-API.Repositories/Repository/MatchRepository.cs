using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VelhIA_API.Repositories.Repository
{
    public class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        public MatchRepository(AppDbContext context) : base(context) { }

        public async Task<Player> GetCurrentPlayer(Guid matchId)
        {
            var match = await dbSet
                .FirstOrDefaultAsync(m => m.Id == matchId);

            var players = await dbSet
                .Where(m => m.Id == matchId)
                .SelectMany(m => m.Players)
                .Select(p => p.Player)
                .ToListAsync();

            return players.First(p => p.StartPlaying == (match.Round % 2 == 0));
        }

        public async Task<(Player, Player)> GetPlayers(Guid matchId)
        {
            var match = await dbSet
                .FirstOrDefaultAsync(m => m.Id == matchId);

            var players = await dbSet
                .Where(m => m.Id == matchId)
                .SelectMany(m => m.Players)
                .Select(p => p.Player)
                .OrderByDescending(p => p.StartPlaying == (match.Round % 2 == 0))
                .ToListAsync();

            return (players.First(), players.Last());
        }

        public async Task<PlayerMove> GetLastMove(Guid matchId)
        {
            var result = await dbSet
                .Where(m => m.Id == matchId)
                .SelectMany(m => m.Players)
                .Select(p => p.Player)
                .SelectMany(p => p.Moves)
                .OrderByDescending(m => m.CreatedOn)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<ICollection<PlayerMove>> GetMoves(Guid matchId)
        {
            var result = await dbSet
                .Where(m => m.Id == matchId)
                .SelectMany(m => m.Players)
                .Select(p => p.Player)
                .SelectMany(p => p.Moves)
                .ToListAsync();

            return result;
        }

        public async Task<bool> AddRound(Guid matchId)
        {
            try
            {
                Match match = await dbSet.FirstOrDefaultAsync(m => m.Id == matchId);

                match.Round += 1;
                await Edit(match);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
