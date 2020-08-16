using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp.Handlers
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Handle();
        
    }
}
