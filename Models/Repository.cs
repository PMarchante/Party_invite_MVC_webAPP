using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<Guestresponse> responses = new List<Guestresponse>();

        public static IEnumerable<Guestresponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(Guestresponse response)
        {
            responses.Add(response);
        }
    }
}
