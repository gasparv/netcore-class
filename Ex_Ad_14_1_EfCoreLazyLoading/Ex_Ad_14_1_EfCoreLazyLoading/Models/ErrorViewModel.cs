using System;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}