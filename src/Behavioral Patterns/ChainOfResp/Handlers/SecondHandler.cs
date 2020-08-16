using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp.Handlers
{
    public sealed class SecondHandler : BaseHandler
    {
        protected override bool IsProcess()
        {
            Int32 value = new Random().Next(2);
            return value == 1;
        }

        protected override void ProcessRequest()
        {
            Console.WriteLine("This is second handler.");
        }
    }
}
