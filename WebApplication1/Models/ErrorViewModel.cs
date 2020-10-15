using System;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string FullName { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}