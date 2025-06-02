namespace Utils;

public struct DivisionResult
{
    public bool Success { get; }
    public double Result { get; }
    public string Message { get; }

    public DivisionResult(bool success, double result, string message)
    {
        Success = success;
        Result = result;
        Message = message;
    }
}