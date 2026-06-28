namespace Catalog.Domain.Repositories;

public interface ICatalogItemRepository
{
    Task<IEnumerable<CatalogItem>> GetAllAsync();
}
