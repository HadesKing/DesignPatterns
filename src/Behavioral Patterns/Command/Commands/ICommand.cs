using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    /// <summary>
    /// Command 接口
    /// </summary>
    public interface ICommand
    {

        void Excute();

        void Rollback();
    }
}
