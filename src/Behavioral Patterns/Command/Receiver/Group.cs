using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public abstract class Group : IReceiver
    {

        /// <summary>
        /// 这里是举个例子，实际使用中，可能会使用参数
        /// </summary>
        public abstract void ExcuteOpeation();

        /// <summary>
        /// 这里是举个例子，实际使用中，可能会使用参数
        /// </summary>
        public abstract void Rollback();
    }
}
