using System;
using My_First_MVC_Application.Models;

namespace My_First_MVC_Application.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}