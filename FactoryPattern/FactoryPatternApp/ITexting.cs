using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public interface ITexting : ICallable
    {
        void SendText();
    }
}
