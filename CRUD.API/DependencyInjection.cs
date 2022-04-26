using CRUD.Interface;
using CRUD.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<ILocacaoRepository, LocacaoRepository>();
           // serviceProvider.AddScoped<IPedidoRepository, PedidoRepository>();
           // serviceProvider.AddScoped<ICidadeRepository, CidadeRepository>();
        }
    }
}