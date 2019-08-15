using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_First_MVC_Application.Models;

namespace My_First_MVC_Application.Views.Home
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}