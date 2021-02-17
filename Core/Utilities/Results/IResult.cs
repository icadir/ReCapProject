

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Status { get; }
        string Message { get; }
    }
}
