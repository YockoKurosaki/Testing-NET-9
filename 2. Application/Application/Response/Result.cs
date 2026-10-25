namespace Application.Response;

public class Result<T>(T? item, bool success, string? message) : ResultBase(success, message)
{
	public T? Item { get; set; } = item;

	public static Result<T> CreateSuccess(T? item, string? message = null) => new(item, success:true, message);

	public static Result<T> CreateFailure(string? message) => new(default, success:false, message);
}