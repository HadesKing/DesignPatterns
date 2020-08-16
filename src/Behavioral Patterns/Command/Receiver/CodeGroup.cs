using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public sealed class CodeGroup : Group
    {
        public override void ExcuteOpeation()
        {
            Console.WriteLine("This is Code Group.");
        }

        public override void Rollback()
        {
            Console.WriteLine("This is Code Group.");
        }
    }
}
