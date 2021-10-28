using System;

namespace BulkyBook.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string MyProperty { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
