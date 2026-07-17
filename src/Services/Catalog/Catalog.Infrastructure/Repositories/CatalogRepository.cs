using Marten;

namespace Catalog.Infrastructure.Repositories;

public class CatalogRepository(IDocumentSession session)
    : IBrandRepository, ICategoryRepository, ICatalogItemRepository
{
    // Get all
    public async Task<IEnumerable<Brand>> GetAllAsync() =>
        await session.Query<Brand>().ToListAsync();

    async Task<IEnumerable<Category>> ICategoryRepository.GetAllAsync() =>
        await session.Query<Category>().ToListAsync();

    async Task<IEnumerable<CatalogItem>> ICatalogItemRepository.GetAllAsync() =>
        await session.Query<CatalogItem>().ToListAsync();

    // Get by criteria
    public async Task<CatalogItem?> GetCatalogItemAsync(Guid id) =>
        await session.LoadAsync<CatalogItem>(id);

    public async Task<IEnumerable<CatalogItem>> GetCatalogItemsByTitleAsync(string title) =>
        await session.Query<CatalogItem>()
            .Where(c => c.Title!.Contains(title))
            .ToListAsync();

    public async Task<IEnumerable<CatalogItem>> GetCatalogItemsByBrandAsync(string brandTitle) =>
        await session.Query<CatalogItem>()
            .Where(c => c.Brand!.Title == brandTitle)
            .ToListAsync();

    // Create
    public async Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item)
    {
        session.Store(item);
        await session.SaveChangesAsync();
        return item;
    }

    // Update
    public async Task<bool> UpdateCatalogItemAsync(CatalogItem item)
    {
        session.Update(item);
        await session.SaveChangesAsync();
        return true;
    }

    // Delete
    public async Task<bool> DeleteCatalogItemAsync(Guid id)
    {
        var item = await session.LoadAsync<CatalogItem>(id);

        if (item is null)
            return false;

        session.Delete(item);
        await session.SaveChangesAsync();
        return true;
    }
}
