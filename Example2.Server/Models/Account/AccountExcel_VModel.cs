using Example2.Server.Models._Base;

namespace Example2.Server.Models.Account
{
    public class AccountExcel_VModel : Base_VModel
    {
        public byte[]? Content { get; set; }

        public string? Filename { get; set; }
    }
}
