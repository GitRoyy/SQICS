using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQICS.Classess
{
    static class Global_Token
    {
        public static string Access_token { get; set; }
        public static int Expires_in { get; set; }
        public static int Refresh_expires_in { get; set; }
        public static string Refresh_token { get; set; }
        public static string Token_type { get; set; }
        public static string Id_token { get; set; }
        public static int Not_before_policy { get; set; }
        public static string Session_state { get; set; }
        public static string Scope { get; set; }
    }
}
