
using MiniAbp.Domain.Repositories;

namespace MiniAbp.EntityFramework.Repositories
{
    public static class EfAutoRepositoryTypes
    {
        public static AutoRepositoryTypesAttribute Default { get; private set; }

        static EfAutoRepositoryTypes()
        {
            Default = new AutoRepositoryTypesAttribute(
                typeof(IRepository<>),
                typeof(IRepository<,>),
                typeof(EfRepositoryBase<,>),
                typeof(EfRepositoryBase<,,>)
            );
        }
    }
}