namespace Catalog.Domain.Specifications;

public record Pagination<T>(
    int PageIndex,
    int PageSize,
    int PageCount,
    IReadOnlyList<T> Items
) where T : class;
