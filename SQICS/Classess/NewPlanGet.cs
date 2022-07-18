using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQICS.Classess
{
    class NewPlanGet
    {

        public Uri GetSubAssyName()
        {
            if (Debugger.IsAttached)
            {
                return new Uri("https://62d4b9d95112e98e485248f2.mockapi.io/Test/api/AssyCode");
            }
            else
            {
                return new Uri("https://62d4b9d95112e98e485248f2.mockapi.io/Test/api/AssyCode");
            }
        }

    }
}
