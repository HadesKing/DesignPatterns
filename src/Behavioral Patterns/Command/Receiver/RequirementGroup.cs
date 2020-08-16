using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public sealed class RequirementGroup : Group
    {
        public override void ExcuteOpeation()
        {
            Console.WriteLine("This is Requirement Group.");
        }

        public override void Rollback()
        {
            Console.WriteLine("This is Requirement Group.");
        }
    }
}
