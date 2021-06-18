using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        public static List<GuestResponse> resposes=new List<GuestResponse>();
       public static IEnumerable<GuestResponse> Responses
        {
            get { return resposes; }
        }

       public static void AddResponses(GuestResponse response)
       {
           resposes.Add(response);
       }
    }
}
