using System;
using System.Collections.Generic;
using System.IO;
using Command.Commands;

namespace Command
{
    /// <summary>
    /// 调用者
    /// </summary>
    public sealed class Invoker
    {
        private ICommand m_command = null;

        public Invoker(ICommand command)
        {
            m_command = command;
        }
        
        /// <summary>
        /// Excute command
        /// </summary>
        public void ExcuteCommand()
        {
            m_command.Excute();
        }
        
        /// <summary>
        /// 回滚
        /// </summary>
        public void Rollback()
        {
            m_command.Rollback();
        }

    }
}
