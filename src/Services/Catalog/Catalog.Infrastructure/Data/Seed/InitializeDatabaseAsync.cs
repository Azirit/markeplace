using Marten;
using Marten.Schema;

namespace Catalog.Infrastructure.Data.Seed;

public class InitializeDatabaseAsync : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        await using var session = store.LightweightSession();

        session.Store(InitialData.Brands);
        session.Store(InitialData.Categories);
        session.Store(InitialData.CatalogItems);

        await session.SaveChangesAsync(cancellation);
    }
}
