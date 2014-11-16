using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM
{
    public static class TokenTools
    {
        public static bool IsValid(string token)
        {
            if ((token == null) || (token == ""))
                return false;

            string[] splittedToken = token.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (splittedToken.Length != 3)
                return false;
            if (splittedToken[1].Length != 32)
                return false;
            if (splittedToken[2].Length != 32)
                return false;

            return true;
        }
    }
}
