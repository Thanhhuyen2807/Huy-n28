namespace demomvc.Models;

public class ErrorViewModels
{
    public string? RequestId { get; set; }

    public bool ShowRequestId
    {
        get
        {
            return !string.IsNullOrEmpty(RequestId);
        }
    }
}
