using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class NotFoundInEnums : Exception
    {
        public NotFoundInEnums(string type)
            : base($"Unknown {type} in Type")
        {
        }
    }
}
