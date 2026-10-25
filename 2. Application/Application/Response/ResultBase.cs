namespace Application.Response;

public abstract class ResultBase(bool success, string? message)
{
	public bool Success { get; set; } = success;
	public string? Message { get; set; } = message;
}
