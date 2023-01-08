using System;
namespace Ecom_Project.Models
{
public class loginModel
{
    
    
    public string? email_id { get; set; }
    public string? password { get; set; }
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}