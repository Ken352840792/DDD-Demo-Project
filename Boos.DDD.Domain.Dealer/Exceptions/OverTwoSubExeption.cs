using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public class OverTwoSubExeption : Exception
    {
        public OverTwoSubExeption(string msg) : base(msg)
        {
        }
    }
}