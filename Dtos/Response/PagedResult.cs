namespace Utils.Response;

public class PagedResult<T>(IReadOnlyList<T>? items, int totalCount, int page, int pageSize, bool success,	string? message) 
	: ResultBase(success, message)
{
	public IReadOnlyList<T>? Items { get; set; } = items;
	public int TotalCount { get; set; } = totalCount;
	public int Page { get; set; } = page;
	public int PageSize { get; set; } = pageSize;
	public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
	public bool HasPreviousPage => Page > 1;
	public bool HasNextPage => Page < TotalPages;

	public static PagedResult<T> CreateSuccess(IReadOnlyList<T> items, int totalCount, int page, int pageSize) => new(items, totalCount, page, pageSize, success:true, message:null);

	public static PagedResult<T> CreateFailure(string? message) => new(Array.Empty<T>(), 0, 1, 0, success: false, message);
}
