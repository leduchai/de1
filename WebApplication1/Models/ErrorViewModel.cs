using System;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}