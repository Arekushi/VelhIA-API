using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Repositories.Repository;
using VelhIA_API.Services.Service;

namespace VelhIA_API.IoC.DI
{
    public static class DependencyInjection
    {
        public static void ConfigureBusinessServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            if (services != null)
            {
                services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
                services.AddTransient<IBoardRepository, BoardRepository>();
                services.AddTransient<IColumnRepository, ColumnRepository>();
                services.AddTransient<ILineRepository, LineRepository>();
                services.AddTransient<IMatchRepository, MatchRepository>();
                services.AddTransient<IPlayerRepository, PlayerRepository>();
                services.AddTransient<IPlayerMoveRepository, PlayerMoveRepository>();
                services.AddTransient<IResultRepository, ResultRepository>();
                services.AddTransient<IVictoryRepository, VictoryRepository>();

                services.AddScoped<IService, Service>();
                services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,>));
                services.AddTransient<IBoardService, BoardService>();
                services.AddTransient<IColumnService, ColumnService>();
                services.AddTransient<ILineService, LineService>();
                services.AddTransient<IMatchService, MatchService>();
                services.AddTransient<IPlayerService, PlayerService>();
                services.AddTransient<IPlayerMoveService, PlayerMoveService>();
                services.AddTransient<ITicTacToeService, TicTacToeService>();
                services.AddTransient<IResultService, ResultService>();
                services.AddTransient<IVictoryService, VictoryService>();
            }
        }

        public static void ConfigureMappings(this IServiceCollection services)
        {
            if (services != null)
            {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
            }
        }
    }
}
