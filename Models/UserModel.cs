using System;
namespace Ecom_Project.Models
{
public class UserModel
{
    
    public int cust_id { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public string? email_id { get; set; }
    public string? password { get; set; }
    public string? RequestId { get; set; }

    // public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}
