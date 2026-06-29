using Marten;

namespace Catalog.Infrastructure.Repositories;

public class CatalogRepository(IDocumentSession session) : IBrandRepository, ICategoryRepository, ICatalogItemRepository
{
    public async Task<IEnumerable<Brand>> GetAllAsync() => await session.Query<Brand>().ToListAsync();
    public async Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCatalogItemAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CatalogItem>> GetAllCatalogItemsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CatalogItem?> GetCatalogItemAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CatalogItem>> GetCatalogItemsByBrandAsync(string brandTitle)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CatalogItem>> GetCatalogItemsByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCatalogItemAsync(CatalogItem item)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<CatalogItem>> ICatalogItemRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
