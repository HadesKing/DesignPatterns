using System;
using System.Collections.Generic;
using System.Text;
using Command.Receiver;

namespace Command.Commands
{
    public abstract class BaseCommand : ICommand
    {
        
        public abstract void Excute();

        public abstract void Rollback();

    }
}
